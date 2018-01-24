using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Net.Mail;
using System.Net;
using DevExpress.XtraEditors;
using SWIBLL;
using System.Net.Mime;
using System.IO;
using DevExpress.XtraLayout;
using SWIBLL.Models;
//using Microsoft.Exchange.WebServices.Data;

namespace DXSWI.Forms
{
    public partial class dlgMailEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private SmtpClient _client = null;
        private MailMessage _emailMessage = null;
        private Dictionary<string, string> _indexAndAttachments = new Dictionary<string, string>();
        LayoutControlGroup lcgAttachments;
        int _indexAttachmentName = 0;
        int _numberOfSentMail = -1;
        string _finalMessage = string.Empty;

        List<long> _runningTaskIds;
        List<string> _candidateEmails;
        List<string> _candidateNames;

        public dlgMailEdit(List<long> runningTaskIds, List<string> emails, List<string> names)
        {
            InitializeComponent();
            initMailServer();
            _candidateEmails = emails;
            _candidateNames = names;
            _runningTaskIds = runningTaskIds;
            _numberOfSentMail = _candidateEmails.Count;
            init(emails);
        }
        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            int index = (int)e.UserState;
            _numberOfSentMail--;
            if (e.Error != null)
            {
                _finalMessage = string.Format("[{0}] {1}", _candidateEmails[index], e.Error.ToString());
            }
            else
            {
                try
                {
                    // todo: add activity when send ok
                    Activity act = new Activity()
                    {
                        Type = "E-mail",
                        ActivityOf = Activity.TypeOfLogActivity.Pipeline,
                        RunningTaskId = _runningTaskIds[index],
                        Status = Activity.RunningTaskStatus.CONTACTED,
                        Notes = string.Format("[{0}] Message sent {1}.\r\n{3}", _candidateEmails[index], DateTime.Now.ToString("hh:mm:ss dd/MM/yyy"), _emailMessage.Body),
                    };
                    ActivityManager.insert(act, null);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (_numberOfSentMail == 0)
            {
                _emailMessage?.Dispose();
                Close();
            }
        }


        private void init(List<string> candidates)
        {
            // check email
            if (Properties.Settings.Default.EmailAccount == "" || UserManager.ActivatedUser.EmailAccount != Properties.Settings.Default.EmailAccount)
            {
                // setup mail:
                XtraMessageBox.Show("Setup email information for this account", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dlgEmailSetting dlg = new dlgEmailSetting();
                dlg.SetEmailAddress(UserManager.ActivatedUser.EmailAccount);
                dlg.ShowDialog();
            }

            textEditFrom.Text = Properties.Settings.Default.EmailAccount;
            textEditTo.Text = String.Join("; ", _candidateEmails);
            if (textEditTo.Text.Trim() == "")
            {
                textEditSubject.Focus();
            }
            else
            {
                textEditTo.Focus();
            }

            // add button add name, add 

            //textEditTo.Text = "phuongdv@live.com";
            //textEditSubject.Text = "Test";
            //recMailContent.LoadDocument(@"C:\Users\phuon\Documents\testmail.docx");
        }

        private void initMailServer()
        {
            _client = new SmtpClient();
            _client.Port = Properties.Settings.Default.EmailSmtpServerPort;
            _client.Host = Properties.Settings.Default.EmailSmtpServer;
            _client.EnableSsl = true;
            _client.Timeout = 10000;
            _client.DeliveryMethod = SmtpDeliveryMethod.Network;
            _client.UseDefaultCredentials = false;
            _client.Credentials = new NetworkCredential(Properties.Settings.Default.EmailAccount, Properties.Settings.Default.EmailPassword);

        }

        private void bbiMailSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            // setup mail:
            dlgEmailSetting dlg = new dlgEmailSetting();
            dlg.ShowDialog();
        }

        private void dlgMailEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private bool validateUi()
        {

            try
            {
                if (textEditFrom.Text.Trim() == "")
                {
                    textEditFrom.Focus();
                    throw new Exception("Fill in required fields");
                }
                if (textEditTo.Text.Trim() == "")
                {
                    textEditTo.Focus();
                    throw new Exception("Fill in required fields");
                }
                if (textEditSubject.Text.Trim() == "")
                {
                    textEditSubject.Focus();
                    throw new Exception("Fill in required fields");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void sendMailViaSmptClient(int index)
        {
            MailAddress senderAddress = new MailAddress(textEditFrom.Text.Trim(), UserManager.ActivatedUser.UserName, Encoding.UTF8);
            MailAddress recipientAddress = new MailAddress(_candidateEmails[index], _candidateNames[index]);

            _emailMessage = new MailMessage(senderAddress, recipientAddress);
            _emailMessage.SubjectEncoding = UTF8Encoding.UTF8;
            _emailMessage.BodyEncoding = UTF8Encoding.UTF8;

            _emailMessage.Subject = textEditSubject.Text.Trim();
            _emailMessage.Body = recMailContent.Text; // use 2 view to avoid go to spam folder?
                                                      //email.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            RichEditMailMessageExporter exporter = new RichEditMailMessageExporter(recMailContent, _emailMessage);
            exporter.Export();

            // add attachments
            foreach (var filePath in _indexAndAttachments.Values)
            {
                System.Net.Mail.Attachment data = new System.Net.Mail.Attachment(filePath, MediaTypeNames.Application.Octet);
                ContentDisposition disposition = data.ContentDisposition;
                disposition.CreationDate = File.GetCreationTime(filePath);
                disposition.ModificationDate = File.GetLastWriteTime(filePath);
                disposition.ReadDate = File.GetLastAccessTime(filePath);
                _emailMessage.Attachments.Add(data);
            }

            // add bcc
            _emailMessage.Bcc.Add(textEditFrom.Text.Trim());
            // Set the method that is called back when the send operation ends.
            _client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            // The userState can be any object that allows your callback 
            // method to identify this send operation.
            // For this example, the userToken is a string constant.
            //string userState = candidateEmail + ": " + _emailMessage.Subject + ";" + runningTaskId.ToString();
            _client.SendAsync(_emailMessage, index);
            this.Hide();
        }
        //private static bool RedirectionUrlValidationCallback(string redirectionUrl)
        //{
        //var redirectionUri = new Uri(redirectionUrl);
        //var result = redirectionUri.Scheme == "https";
        //return result;
        //}
        //private void sendMailViaWES()
        //{
        //try
        //{
        //    ExchangeService service = new ExchangeService();
        //    //// In case you have a dodgy SSL certificate:
        //    //System.Net.ServicePointManager.ServerCertificateValidationCallback =
        //    //            delegate (Object obj, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        //    //            {
        //    //                return true;
        //    //            };
        //    service.Credentials = new WebCredentials(Properties.Settings.Default.EmailAccount, Properties.Settings.Default.EmailPassword);
        //    service.TraceEnabled = true;
        //    service.TraceFlags = TraceFlags.All;
        //    service.AutodiscoverUrl(textEditFrom.Text.Trim(), RedirectionUrlValidationCallback);

        //    EmailMessage mes = new EmailMessage(service);
        //    mes.Subject = textEditSubject.Text.Trim();
        //    mes.Body = new MessageBody("Test send from add via wes");
        //    mes.Sender = new EmailAddress(textEditFrom.Text.Trim());
        //    mes.ToRecipients.Add(textEditTo.Text.Trim());
        //    //mes.Save();
        //    mes.SendAndSaveCopy(WellKnownFolderName.SentItems);
        //    this.Close();
        //}
        //catch (Exception ex)
        //{
        //    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        //}
        private void sbSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateUi()) return;
                if (_candidateEmails.Count == 1)
                {
                    sendMailViaSmptClient(0);
                }
                else if (_candidateEmails.Count > 1)
                {
                    for (var i = 0; i < _candidateEmails.Count; ++i)
                    {
                        string canEmail = _candidateEmails[i];
                        string canName = _candidateNames[i];
                        long runId = _runningTaskIds[i];
                        // todo: generate Email from template

                        // send mail
                        sendMailViaSmptClient(i);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void bbiFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Multiselect = true;

            if (openFileDlg.ShowDialog() != DialogResult.OK)
                return;
            // check size of file
            if (new System.IO.FileInfo(openFileDlg.FileName).Length > 10e6) // 10MB
            {
                XtraMessageBox.Show("Attactment is too big (more than 10 MB)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] files = openFileDlg.FileNames;
            foreach (var linkAttachment in files)
            {
                if (_indexAndAttachments.ContainsValue(linkAttachment))
                {
                    continue;
                }
                string fileName = linkAttachment.Split('\\').Last();
                _indexAttachmentName++;
                string index = "sb" + _indexAttachmentName.ToString(); // name of attachment
                _indexAndAttachments.Add(index, linkAttachment);
                // update to ui
                lcgMain.BeginUpdate();
                try
                {
                    if (_indexAndAttachments.Count == 1)
                    {

                        lcgAttachments = lcgMain.AddGroup();
                        lcgAttachments.Name = "lcgAttachments";
                        lcgAttachments.Text = "Attachments";
                        lcgAttachments.Move(lciMailContent, DevExpress.XtraLayout.Utils.InsertType.Top);
                        //lcgAttachments.Move(lciSubject, DevExpress.XtraLayout.Utils.InsertType.Bottom);
                        lcgAttachments.StartNewLine = false;
                        lcgAttachments.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Flow;
                    }
                    //create layout item within the group.
                    //LayoutControlItem it1 = lcgAttachments?.AddItem();
                    //ucAttachmentFile at = new ucAttachmentFile(fileName);
                    //it1.Control = at;
                    //it1.TextVisible = false;
                    LayoutControlItem it1 = lcgAttachments?.AddItem();
                    SimpleButton btn = new SimpleButton();
                    btn.MaximumSize = new Size(35, 35);
                    btn.MinimumSize = new Size(35, 35);
                    btn.ImageOptions.Image = Properties.Resources.delete_16x16;
                    btn.ImageOptions.Location = ImageLocation.MiddleCenter;
                    btn.Click += Delete_Attachment_Click;
                    btn.Name = index;
                    //this.sbDelete.Click += new System.EventHandler(this.sbDelete_Click);
                    it1.Control = btn;
                    it1.Text = fileName;
                    it1.Name = "lci" + btn.Name;

                }
                finally
                {
                    lcgMain.EndUpdate();
                }
            }
        }

        private void Delete_Attachment_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleButton btn = sender as SimpleButton;
                _indexAndAttachments.Remove(btn.Name);
                lcgAttachments.BeginUpdate();
                lcMain.GetItemByControl(btn).Dispose();
                btn.Dispose();
                lcgAttachments.EndUpdate();

                if (_indexAndAttachments.Count == 0)
                {
                    lcgMain.BeginUpdate();
                    lcgMain.Remove(lcgAttachments);
                    lcgMain.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}