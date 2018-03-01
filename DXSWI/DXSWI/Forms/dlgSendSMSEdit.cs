using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SWIBLL.Models;
using SWIBLL;
using System.Text.RegularExpressions;

namespace DXSWI.Forms
{
    public partial class dlgSendSMSEdit : DevExpress.XtraEditors.XtraForm
    {
        List<string> _listNumbers = null;
        List<string> _listNames = null;
        List<string> _listEmails = null;

        List<SmsTemplate> _smsTemplates = null;
        public dlgSendSMSEdit(List<string> listNumbers, List<string> listNames, List<string> listEmails)
        {
            InitializeComponent();
            _listNumbers = listNumbers;
            _listNames = listNames;
            _listEmails = listEmails;
            tePhoneNumbers.ReadOnly = true;
            //tePhoneNumbers.Text = string.Join(";", _listNumbers);
            tePhoneNumbers.Text = Regex.Replace(string.Join(";", _listNumbers), @";+", ";", RegexOptions.Multiline);
            if (tePhoneNumbers.Text.StartsWith(";"))
            {
                tePhoneNumbers.Text = tePhoneNumbers.Text.Remove(0, 1);
            }
        }

        void updateData()
        {
            // update list template
            _smsTemplates = SmsManager.GetlistSmsTemplates();
            cbeTemplates.Properties.Items.Clear();
            cbeTemplates.Properties.Items.Add("None");
            cbeTemplates.Properties.Items.AddRange(_smsTemplates.Select(sms => sms.Title).ToList());
        }

        private void sbHelp_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Use variable for different candidates:\r\n[name] : candidate's name \r\n[email] : candidate's email.");
        }

        private void meMessage_EditValueChanged(object sender, EventArgs e)
        {
            lciContent.Text = string.Format("Message [{0}]", 160 - meMessage.Text.Length);
        }

        private void dlgSendSMSEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    sbSend.PerformClick();
                    break;
                case Keys.S:
                    if (e.Control)
                    {
                        sbSaveTemplate.PerformClick();
                    }
                    break;
                default:
                    break;
            }
        }

        private void dlgSendSMSEdit_Load(object sender, EventArgs e)
        {
            updateData();
        }

        private void sbSaveTemplate_Click(object sender, EventArgs e)
        {
            string sms = meMessage.Text.Trim();
            if (sms.Length > 160)
            {
                if (XtraMessageBox.Show("Length of message more than 160 characters. Would you like to continues?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    return;
                }
            }
            // save the template to DB
            if (cbeTemplates.SelectedIndex != 0)
            {
                // update current template
                if (XtraMessageBox.Show("Are you sure to update this template", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //update to Db
                    try
                    {
                        SmsTemplate tmp = _smsTemplates[cbeTemplates.SelectedIndex - 1];
                        tmp.Message = sms;
                        SmsManager.UpdateSmsTemplate(tmp);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                dlgSaveSmsTemplate dlg = new dlgSaveSmsTemplate(sms);
                dlg.ShowDialog();
            }

            updateData();
        }

        private void sbSend_Click(object sender, EventArgs e)
        {
            //validate data
            // generate sms message and save to db of sending table for gsm module service auto send it soon
            // show warning if lenght > 160            
            string sms = meMessage.Text.Trim();
            if (sms.Length > 160)
            {
                if (XtraMessageBox.Show("Length of message more than 160 characters and it's will take more cost to send sms. Would you like to continues?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    return;
                }
            }
            for (var i = 0; i < _listNumbers.Count; ++i)
            {
                try
                {
                    string number = _listNumbers[i];
                    string name = _listNames[i];
                    string email = _listEmails[i];
                    string message = sms.Replace("[name]", name).Replace("[email]", email);
                    if(message.Length > 160)
                    {
                        throw new Exception(string.Format("Cant send to {0} number {1} email {2} because message lengh > 160", name, number, email));
                    }
                    SaveSmsToDb(number, message);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Close();
        }

        private void SaveSmsToDb(string number, string sms)
        {
            // correct number:
            // +84 -> 0; 84 -> 0; remove ".", " ", " "
            if (number.StartsWith("+84"))
            {
                number = "0" + number.Remove(0, 3);
            }
            if (number.StartsWith("84"))
            {
                number = "0" + number.Remove(0, 2);
            }
            number = number.Replace(".", "").Replace("-", "").Replace(" ", "").Trim();
            // if not start by 0 -> do not sent

            if (number.StartsWith("0"))
            {
                SmsSending tmp = new SmsSending() { PhoneNumber = number, Message = sms, Status = "Sending", TimeToSend = DateTime.Now };
                SmsManager.InsertSmsSending(tmp);
            }


        }

        private void cbeTemplates_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbeTemplates.SelectedIndex != 0)
                {
                    SmsTemplate tmp = _smsTemplates[cbeTemplates.SelectedIndex - 1];
                    meMessage.Text = tmp.Message;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}