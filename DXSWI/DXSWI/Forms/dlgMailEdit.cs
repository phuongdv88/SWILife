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
using DXSWI.Modules;
using DevExpress.XtraRichEdit;
using DXSWI.Controls;
using System.Text.RegularExpressions;
//using Microsoft.Exchange.WebServices.Data;

namespace DXSWI.Forms
{
    public partial class dlgMailEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //private SmtpClient _client = null;
        //private MailMessage _emailMessage = null;
        private Dictionary<string, string> _indexAndAttachments = new Dictionary<string, string>();
        List<SimpleButton> _listRemoveAttachmentsButton = new List<SimpleButton>();
        LayoutControlItem lcAttachments = null;
        ucAttachmentMail _attactmentMail = null;
        int _indexAttachmentName = 0;
        int _numberOfSentMail = -1;
        string _finalMessage = string.Empty;
        string _companyName = string.Empty;
        string _jobTitle = string.Empty;
        long _jobOrderId = -1;
        List<long> _runningTaskIds;
        List<string> _candidateEmails;
        List<string> _candidateNames;
        List<long> _candidateIds;

        public dlgMailEdit()
        {
            InitializeComponent();
            //initMailServer();
           

        }

       
        public void Init(List<long> runningTaskIds, List<string> emails, List<string> names, List<long> candidateIds, string companyName, string jobTitle, long jobOrderId)
        {
            if(lcAttachments != null)
            {
                _indexAndAttachments.Clear();
                foreach(var btn in _listRemoveAttachmentsButton)
                {
                    btn.Dispose();
                }
                _listRemoveAttachmentsButton.Clear();

                lcgMain.BeginUpdate();
                lcgMain.Remove(lcAttachments);
                lcAttachments.Dispose();
                _attactmentMail.Dispose();
                lcgMain.EndUpdate();
            }
            _indexAttachmentName = 0;
            _numberOfSentMail = -1;
            _finalMessage = string.Empty;

            _candidateEmails = emails;
            _candidateNames = names;
            _candidateIds = candidateIds;
            _runningTaskIds = runningTaskIds;
            _numberOfSentMail = _candidateEmails.Count;
            _companyName = companyName;
            _jobTitle = jobTitle;
            _jobOrderId = jobOrderId;
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
            textEditSubject.Text = string.Empty;
            recMailContent.Text = string.Empty;

            try
            {
                string linkSignatureFile = string.Format(@"{0}user\signature\{1}\signature.doc", Properties.Settings.Default.StorageLocation, UserManager.ActivatedUser.UserName);
                if (File.Exists(linkSignatureFile))
                {
                    recMailContent.LoadDocument(linkSignatureFile);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            try
            {
                int index = (int)e.UserState;
                _numberOfSentMail--;
                if (e.Error != null)
                {
                    var msg = string.Format("[{0}] {1}", _candidateEmails[index], e.Error.ToString());
                    ScreenManager.Instance.ShowNoticeMessage(msg, "Send Email Fail", MessageBoxIcon.Information);
                    _finalMessage += msg;
                }
                else
                {
                    try
                    {
                        Activity act = new Activity()
                        {
                            Type = "E-mail",
                            ActivityOf = Activity.TypeOfLogActivity.Pipeline,
                            RunningTaskId = _runningTaskIds[index],
                            CandidateId = _candidateIds[index],
                            JobOrderId = _jobOrderId,
                            Status = Activity.RunningTaskStatus.CONTACTED,
                            Notes = string.Format("[{0}] Message sent {1}.", _candidateEmails[index], DateTime.Now.ToString("HH:mm:ss dd/MM/yyy")),
                        };
                        ActivityManager.insert(act);
                        ScreenManager.Instance.ShowNoticeMessage(act.Notes, "Email sent successfully", MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (_numberOfSentMail == 0)
                {
                    if (_finalMessage.Length > 0)
                    {
                        XtraMessageBox.Show(_finalMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //_emailMessage?.Dispose();
                    //Close();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    //this.Close();
                    Hide();
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

        private void sendMailViaSmptClient(int index, bool isAutoGenerate = false)
        {
            SmtpClient client = new SmtpClient();
            client.Port = Properties.Settings.Default.EmailSmtpServerPort;
            client.Host = Properties.Settings.Default.EmailSmtpServer;
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(Properties.Settings.Default.EmailAccount, Properties.Settings.Default.EmailPassword);

            MailAddress senderAddress = new MailAddress(textEditFrom.Text.Trim(), UserManager.ActivatedUser.UserName, Encoding.UTF8);
            MailAddress recipientAddress = new MailAddress(_candidateEmails[index], _candidateNames[index]);

            MailMessage emailMessage = new MailMessage(senderAddress, recipientAddress);
            emailMessage.SubjectEncoding = UTF8Encoding.UTF8;
            emailMessage.BodyEncoding = UTF8Encoding.UTF8;
            if (isAutoGenerate)
            {

                emailMessage.Subject = autoGenerateEmail(textEditSubject.Text.Trim(), index);
                emailMessage.Body = autoGenerateEmail(recMailContent.Text, index); // use 2 view to avoid go to spam folder?
                                                                                   //email.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                string temp = recMailContent.HtmlText;
                recMailContent.HtmlText = autoGenerateEmail(temp, index);

                RichEditMailMessageExporter exporter = new RichEditMailMessageExporter(recMailContent, emailMessage);
                exporter.Export();

                recMailContent.HtmlText = temp;
            }
            else
            {
                emailMessage.Subject = textEditSubject.Text.Trim();
                emailMessage.Body = recMailContent.Text; // use 2 view to avoid go to spam folder?
                RichEditMailMessageExporter exporter = new RichEditMailMessageExporter(recMailContent, emailMessage);
                exporter.Export();
            }

            // add attachments
            foreach (var filePath in _indexAndAttachments.Values)
            {
                System.Net.Mail.Attachment data = new System.Net.Mail.Attachment(filePath, MediaTypeNames.Application.Octet);
                ContentDisposition disposition = data.ContentDisposition;
                disposition.CreationDate = File.GetCreationTime(filePath);
                disposition.ModificationDate = File.GetLastWriteTime(filePath);
                disposition.ReadDate = File.GetLastAccessTime(filePath);
                emailMessage.Attachments.Add(data);
            }

            // add bcc
            emailMessage.Bcc.Add(textEditFrom.Text.Trim());
            // Set the method that is called back when the send operation ends.
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            // The userState can be any object that allows your callback 
            // method to identify this send operation.
            // For this example, the userToken is a string constant.
            //string userState = candidateEmail + ": " + _emailMessage.Subject + ";" + runningTaskId.ToString();
            client.SendAsync(emailMessage, index);
        }
        private void sbSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateUi()) return;
                if (_candidateEmails.Count == 1)
                {
                    Hide();
                    sendMailViaSmptClient(0);
                }
                else if (_candidateEmails.Count > 1)
                {
                    dlgPreviewEmail dlg = new dlgPreviewEmail(textEditSubject.Text, recMailContent.HtmlText, _candidateNames[0], _companyName, _jobTitle);
                    dlg.sendEmailEvent += startSendEmails;
                    dlg.ShowDialog();
                }

                //this.Hide();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Close();
                Hide();
            }
        }

        private void startSendEmails()
        {
            try
            {
                Hide();
                for (var i = 0; i < _candidateEmails.Count; ++i)
                {
                    string canEmail = _candidateEmails[i];
                    string canName = _candidateNames[i];
                    long runId = _runningTaskIds[i];
                    // send mail
                    sendMailViaSmptClient(i, true);

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        // add group control
                        _attactmentMail = new ucAttachmentMail();
                        lcAttachments = lcgMain.AddItem();
                        lcAttachments.Name = "lcgAttachments";
                        lcAttachments.TextVisible = false;
                        lcAttachments.Move(lciMailContent, DevExpress.XtraLayout.Utils.InsertType.Top);
                        lcAttachments.Control = _attactmentMail;
                        lcAttachments.SizeConstraintsType = SizeConstraintsType.Custom;
                        lcAttachments.ControlMaxSize = new Size(1024, 100);
                        // add layoutControl
                    }
                    LayoutControlItem it1 = _attactmentMail.lcgAttachment?.AddItem();
                    SimpleButton btn = new SimpleButton();
                    btn.MaximumSize = new Size(35, 35);
                    btn.MinimumSize = new Size(35, 35);
                    btn.ImageOptions.Image = Properties.Resources.delete_16x16;
                    btn.ImageOptions.Location = ImageLocation.MiddleCenter;
                    btn.Click += Delete_Attachment_Click;
                    btn.Name = index;
                    _listRemoveAttachmentsButton.Add(btn);
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
                _listRemoveAttachmentsButton.Remove(btn);
                _attactmentMail.lcgAttachment.BeginUpdate();
                _attactmentMail.lcAttachment.GetItemByControl(btn).Dispose();
                btn.Dispose();
                _attactmentMail.lcgAttachment.EndUpdate();

                if (_indexAndAttachments.Count == 0)
                {
                    lcgMain.BeginUpdate();
                    lcAttachments?.Dispose();
                    _attactmentMail?.Dispose();
                    lcgMain.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbiInsertTemplate_ItemClick(object sender, ItemClickEventArgs e)
        {
            dlgTemplateSetting dlg = new dlgTemplateSetting();
            dlg.updateDataEvent += insertTemplate;
            dlg.ShowDialog();
        }

        private void insertTemplate(string subject, string content)
        {
            // if send to many candidates, use original form of template, else auto generate to final mail
            if (_candidateEmails.Count > 1)
            {
                recMailContent.HtmlText = content;
                textEditSubject.Text = subject;
            }
            else
            {
                recMailContent.HtmlText = autoGenerateEmail(content, 0);
                textEditSubject.Text = autoGenerateEmail(subject, 0);
            }
        }

        private string autoGenerateEmail(string template, int canIndex)
        {
            return template.Replace("[name]", _candidateNames[canIndex]).Replace("[company]", _companyName).Replace("[job]", _jobTitle);
        }

        private void bbiSignatureSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            dlgSignatureEdit dlg = new dlgSignatureEdit();
            dlg.updateSignatureEvent += updateSignature;
            dlg.ShowDialog();
        }

        private void updateSignature(string signature)
        {
            recMailContent.Document.AppendText("\r\n");
            recMailContent.Document.AppendHtmlText(signature);
        }
    }
}