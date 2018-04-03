using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using SWIBLL.Models;

namespace SmsSenderService
{
    /// <summary>
    /// this class used to maintain GSM module including: connect, disconect, send sms, read sms, delete sms
    /// </summary>

    public interface IGSMController
    {
        void OpenPort(string strPort, int baudRate, int dataBits, int readTimeout, int writeTimeout);
        void Close();

        bool SendSMS(string number, string message);
    }
    public class GSMController : IGSMController
    {
        private AutoResetEvent _receivingTriger = new AutoResetEvent(false);
        private SerialPort _port = null;
        public void OpenPort(string strPort, int baudRate = 9600, int dataBits = 8, int readTimeout = 500, int writeTimeout = 500)
        {
            _port = new SerialPort();
            try
            {
                _port.PortName = strPort;                 //COM1
                _port.BaudRate = baudRate;                   //9600
                _port.DataBits = dataBits;                   //8
                _port.StopBits = StopBits.One;                  //1
                _port.Parity = Parity.None;                     //None
                _port.ReadTimeout = readTimeout;             //300
                _port.WriteTimeout = writeTimeout;           //300
                //port.Encoding = Encoding.UTF8;
                _port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                _port.Open();
                _port.DtrEnable = true;
                _port.RtsEnable = true;
            }
            catch
            {
                throw;
            }
        }

        public void Close()
        {
            if (_port == null) return;
            try
            {
                _port.Close();
                _port.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
                _port.Dispose();
            }
            catch
            {
                throw;
            }
        }
        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (e.EventType == SerialData.Chars)
                {
                    // emit signal to where waiting respond message
                    _receivingTriger.Set();
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// read response data from port
        /// </summary>
        /// <param name="port"></param>
        /// <param name="timeout"></param>
        public string ReadResponse(int timeout = 500)
        {
            string buffer = string.Empty;
            try
            {
                do
                {
                    if (_receivingTriger.WaitOne(timeout, false))
                    {
                        buffer += _port?.ReadExisting();
                    }
                    else
                    {
                        if (buffer.Length > 0)
                            throw new ApplicationException("Response received is incomplete." + buffer);
                        else
                            throw new ApplicationException("No data received from phone.");
                    }

                }
                while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\"\r\r\n> ") && !buffer.EndsWith("\r\nERROR\r\n"));

            }
            catch
            {
                throw;
            }
            return buffer;
        }

        /// <summary>
        /// excute AT command
        /// </summary>
        /// <param name="port"></param>
        /// <param name="command"></param>
        /// <param name="responseTimeout"></param>
        /// <returns></returns>
        public string ExecCommand(string command, int responseTimeout = 500, string failMessage = "No success message was received.")
        {
            try
            {
                _port?.DiscardOutBuffer();
                _port?.DiscardInBuffer();
                _receivingTriger.Reset();

                _port?.Write(command + "\r");
                string result = ReadResponse(responseTimeout);
                if ((result.Length == 0) || ((!result.EndsWith("\"\r\r\n> ")) && (!result.EndsWith("\r\nOK\r\n"))))
                    throw new ApplicationException(command + ": " + failMessage);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(command + ":" + ex.Message);
            }
        }

        public bool SendSMS(string number, string message)
        {
            bool isSent = false;
            try
            {
                string command = string.Empty;
                command = "AT";
                string test = ExecCommand(command, 1000, "No phone connected");
                command = "AT+CMGF=1"; // set gsm module to text mode
                test = ExecCommand(command, 1000, "Failed to set GSM module to text mode.");
                command = string.Format("AT+CMGS=\"{0}\"", number);
                test = ExecCommand(command, 1000, "Failed to accept phoneNo");
                command = message + char.ConvertFromUtf32(26) + "\r";
                string result = ExecCommand(command, 10000, "Failed to send message");
                if (result.EndsWith("\r\nOK\r\n"))
                {
                    isSent = true;
                }
            }
            catch
            {
                throw;
            }
            return isSent;
        }
        /// <summary>
        /// Delete message on Sim card
        /// </summary>
        /// <param name="port"></param>
        /// <param name="index">if index <= 0, delete all sms. If not, delete only message have this index value</param>
        /// <returns></returns>
        public bool DeleteSMS(int index = -1)
        {
            bool isDeleted = false;
            try
            {
                string command = string.Empty;
                command = "AT";
                ExecCommand(command, 500, "No phone connected");
                command = "AT+CMGF=1"; // set gsm module to text mode
                ExecCommand(command, 500, "Failed to set GSM module to text mode.");

                if (index <= 0)
                {
                    // delete all 
                    command = "AT+CMGD=1,4";
                }
                else
                {
                    command = string.Format("AT+CMGD={0}", index);
                }
                string result = ExecCommand(command, 10000, "Failed to delete messages");
                if (result.EndsWith("\r\nOK\r\n"))
                {
                    isDeleted = true;
                }
            }
            catch
            {
                throw;
            }


            return isDeleted;
        }

        public SmsReceivingCollection ReadSMS()
        {
            SmsReceivingCollection msgs = null;
            try
            {
                string command = "AT";
                ExecCommand(command, 500, "No phone connected");
                command = "AT+CMGF=1"; // set gsm module to text mode
                ExecCommand(command, 500, "Failed to set GSM module to text mode.");
                command = "AT+CMGL=\"ALL\"";
                string result = ExecCommand(command, 5000, "Failed to read messages");
                //parse mesage
                msgs = parseMessages(result);
            }
            catch
            {
                throw;
            }

            return msgs;
        }

        private SmsReceivingCollection parseMessages(string input)
        {
            SmsReceivingCollection msgs = new SmsReceivingCollection();
            try
            {
                Regex r = new Regex(@"\+CMGL: (\d+),""(.+)"",""(.+)"",(.*),""(.+)""\r\n(.+)\r\n");
                Match m = r.Match(input);
                while (m.Success)
                {
                    SmsReceiving msg = new SmsReceiving();
                    //msg.Index = int.Parse(m.Groups[1].Value);
                    msg.Index = Convert.ToInt16(m.Groups[1].Value);
                    msg.Status = m.Groups[2].Value;
                    msg.Sender = m.Groups[3].Value;
                    msg.Alphabet = m.Groups[4].Value;
                    //'18/03/02,09:59:14+28'
                    msg.SentTime = m.Groups[5].Value;
                    DateTime tmp = DateTime.ParseExact(msg.SentTime, "yy/MM/dd,HH:mm:ss+28", null);
                    if(tmp != null)
                    {
                        msg.SentTime = tmp.ToString("yyyy-MM-dd HH:mm:ss");
                    } else
                    {
                        msg.SentTime = msg.SentTime.Replace(",", " ").Replace("/", "-").Replace("+28", "");
                    }
                    msg.Message = m.Groups[6].Value;
                    msgs.Add(msg);
                    m = m.NextMatch();
                }
            }
            catch
            {

                throw;
            }

            return msgs;
        }

        public int CountSMSmessages()
        {
            int CountTotalMessages = 0;
            try
            {

                #region Execute Command

                string recievedData = ExecCommand("AT", 300, "No phone connected at ");
                recievedData = ExecCommand("AT+CMGF=1", 300, "Failed to set message format.");
                String command = "AT+CPMS?";
                recievedData = ExecCommand(command, 1000, "Failed to count SMS message");
                int uReceivedDataLength = recievedData.Length;

                #endregion

                #region If command is executed successfully
                if ((recievedData.Length >= 45) && (recievedData.StartsWith("AT+CPMS?")))
                {

                    #region Parsing SMS
                    string[] strSplit = recievedData.Split(',');
                    string strMessageStorageArea1 = strSplit[0];     //SM
                    string strMessageExist1 = strSplit[1];           //Msgs exist in SM
                    #endregion

                    #region Count Total Number of SMS In SIM
                    CountTotalMessages = Convert.ToInt32(strMessageExist1);
                    #endregion

                }
                #endregion

                #region If command is not executed successfully
                else if (recievedData.Contains("ERROR"))
                {

                    #region Error in Counting total number of SMS
                    string recievedError = recievedData;
                    recievedError = recievedError.Trim();
                    recievedData = "Following error occured while counting the message" + recievedError;
                    #endregion

                }
                #endregion

                return CountTotalMessages;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



    }
}
