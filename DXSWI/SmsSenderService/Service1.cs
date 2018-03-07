using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using SWIBLL;
using System.Timers;

namespace SmsSenderService
{
    public partial class  ATSSmsSenderService : ServiceBase
    {
        bool _ConnectionWithDB = false;
        GSMController _gsm = null;
        Timer _timer = null;
        public ATSSmsSenderService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Utilities.WriteLog("Start Service");
            _gsm = new GSMController();
            string port = Properties.Settings.Default.GSMPort;
            if (args.Length > 0)
            {
                port = args[0].Trim();
            }
            // open serial port
            try
            {
                Utilities.WriteLog("Open Serial Port: " + port);
                _gsm.OpenPort(port);
            }
            catch (Exception ex)
            {
                Utilities.WriteLog(ex);
            }

            _timer = new Timer();
            _timer.Interval = 20000;
            _timer.Elapsed += timer_Tick;
            _timer.Start();
            connectToDb();
        }

        protected override void OnStop()
        {
            // save log when sevice stoped
            _gsm?.Close();
            Utilities.WriteLog("Service has been stoped");
        }

        void connectToDb()
        {
            try
            {
                Utilities.WriteLog("Open connection to Database");
                UserManager.ConnectoDB(@"server=192.168.0.101;user id=admin;password=Swilife.com1!;persistsecurityinfo=True;database=swilifecore;port=3306;Convert Zero Datetime=true");
                _ConnectionWithDB = true;
            }
            catch (Exception ex)
            {
                _ConnectionWithDB = false;
                Utilities.WriteLog(ex);
            }
        }
        private void timer_Tick(object sender, ElapsedEventArgs args)
        {
            _timer.Stop();
            if (!_ConnectionWithDB)
            {
                connectToDb();
            }
            try
            {
                // get all sending sms of db ( sms with state = Waiting)
                var listSendingMessage = SmsManager.GetlistSmsWaitToSend();
                // send all of this sms
                foreach (var sms in listSendingMessage)
                {
                    Utilities.WriteLog(string.Format("Send sms to {0}: {1}", sms.PhoneNumber, sms.Message));
                    try
                    {
                        if (_gsm.SendSMS(sms.PhoneNumber, sms.Message))
                        {
                            // update state is success to db
                            sms.Status = "Sent";
                            SmsManager.UpdateSmsSending(sms);
                        }
                        else
                        {
                            // update state is fail to db
                            sms.Status = "Resending";
                            SmsManager.UpdateSmsSending(sms);
                        }
                    }
                    catch (Exception ex)
                    {
                        Utilities.WriteLog(ex);
                        sms.Status = "Resending";
                        SmsManager.UpdateSmsSending(sms);
                        return; // return and wait 20s for nex round
                    }
                    System.Threading.Thread.Sleep(1000); // sleep 1 second
                }

                // retry send Resending message
                var listResendingSms = SmsManager.GetlistSmsToResending();
                // send all of this sms
                foreach (var sms in listResendingSms)
                {
                    Utilities.WriteLog(string.Format("Retry to send sms to {0}: {1}", sms.PhoneNumber, sms.Message));
                    try
                    {
                        if (_gsm.SendSMS(sms.PhoneNumber, sms.Message))
                        {
                            // update state is success to db
                            sms.Status = "Sent";
                            SmsManager.UpdateSmsSending(sms);
                        }
                        else
                        {
                            // update state is fail to db
                            sms.Status = "Fail";
                            SmsManager.UpdateSmsSending(sms);
                        }
                    }
                    catch (Exception ex)
                    {
                        // if have error again, set status to Error
                        Utilities.WriteLog(ex);
                        sms.Status = "Error";
                        SmsManager.UpdateSmsSending(sms);
                        return; // return and wait 20s for nex round
                    }
                    System.Threading.Thread.Sleep(1000); // sleep 1 second
                }

                // get all received sms
                if (_gsm.CountSMSmessages() > 0)
                {
                    var messages = _gsm.ReadSMS();
                    foreach (var msg in messages)
                    {
                        try
                        {
                            // save to db
                            SmsManager.InsertSmsReceiving(msg);
                            // delete from SIM
                            _gsm.DeleteSMS(msg.Index);
                        }
                        catch (Exception ex)
                        {
                            Utilities.WriteLog(ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.WriteLog(ex);
            }
            finally
            {

                _timer.Start();
            }
        }

    }
}
