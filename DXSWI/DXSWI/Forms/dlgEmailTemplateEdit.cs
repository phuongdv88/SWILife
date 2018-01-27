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

namespace DXSWI.Forms
{
    public partial class dlgEmailTemplateEdit : DevExpress.XtraEditors.XtraForm
    {
        private EmailTemplate _emailTemplate = null;
        public delegate void updateData();
        public event updateData updateDataEvent;
        public dlgEmailTemplateEdit(int emailTemplateId)
        {
            InitializeComponent();
            _emailTemplate = EmailTemplateManager.GetEmailTemplateById(emailTemplateId);
            fillObjectToUi();
        }

        private void getOjectFromUi()
        {
            if(_emailTemplate == null)
            {
                _emailTemplate = new EmailTemplate();
            }
            _emailTemplate.Language = cbeLanguage.Text.Trim();
            _emailTemplate.Type = cbeType.Text.Trim();
            _emailTemplate.Title = cbeTitle.Text.Trim();
            _emailTemplate.Subject = textEditSubject.Text.Trim();
            _emailTemplate.Content = ucTemplateEditText1.recMain.HtmlText;
        }

        private bool validateUi()
        {
            if(cbeLanguage.Text.Trim() == "")
            {
                cbeLanguage.Focus();
                XtraMessageBox.Show("Language can not be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbeType.Text.Trim() == "")
            {
                cbeType.Focus();
                XtraMessageBox.Show("Type can not be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbeTitle.Text.Trim() == "")
            {
                cbeTitle.Focus();
                XtraMessageBox.Show("Title can not be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textEditSubject.Text.Trim() == "")
            {
                textEditSubject.Focus();
                XtraMessageBox.Show("Subject can not be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ucTemplateEditText1.recMain.Text.Trim() == "")
            {
                ucTemplateEditText1.recMain.Focus();
                XtraMessageBox.Show("Content can not be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void fillObjectToUi()
        {
            if (_emailTemplate == null)
                return;
            cbeLanguage.EditValue = _emailTemplate.Language;
            cbeType.EditValue = _emailTemplate.Type;
            cbeTitle.EditValue = _emailTemplate.Title;
            textEditSubject.Text = _emailTemplate.Subject;
            ucTemplateEditText1.recMain.HtmlText = _emailTemplate.Content;
        }

        private void sbHelp_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Use variable for different candidates:\r\n [name] : candidate name \r\n[company] : company name\r\n[job] : job order title.");
        }

        private void dlgEmailTemplateEdit_KeyDown(object sender, KeyEventArgs e)
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

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            // save
            if (!validateUi())
                return;
            try {
                getOjectFromUi();
                if(_emailTemplate.EmailTemplateId == -1)
                {
                    EmailTemplateManager.InsertEmailTemplate(_emailTemplate);
                } else
                {
                    EmailTemplateManager.UpdateEmailTemplate(_emailTemplate);
                }
                updateDataEvent?.Invoke();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void sbReset_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to reset template?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (_emailTemplate != null)
            {
                ucTemplateEditText1.recMain.HtmlText = _emailTemplate.Content;
                textEditSubject.Text = _emailTemplate.Subject;
            } else
            {
                ucTemplateEditText1.recMain.HtmlText = "";
                textEditSubject.Text = "";
            }
        }

        private void sbPreview_Click(object sender, EventArgs e)
        {
            //todo: show preview form
            dlgPreviewEmail dlg = new dlgPreviewEmail(textEditSubject.Text, ucTemplateEditText1.recMain.HtmlText);
            dlg.setPreviewOnly(true);
            dlg.ShowDialog();
        }
        private void cbeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbeType.SelectedIndex)
            {
                case 0:
                    ucTemplateEditText1.Tooltip = "Use variable for different candidates:\r\n[name] : candidate name \r\n[company] : company name\r\n[job] : job order title.";
                    break;
                case 1://Invitation
                    ucTemplateEditText1.Tooltip = "Use this template at first time to connect with candidate.\r\n" +
                                            "- Write exact name of candidate\r\n" +
                                            "- Don’t provide Company name\r\n" +
                                            "- Write the general attractive information, short and easy to read.\r\n" +
                                            "- Ask for connection\r\n";
                    break;
                case 2://Introduction
                    ucTemplateEditText1.Tooltip = "Use this template when sending jobs via email to candidates\r\n" +
                                            "- Write exact name of candidate\r\n" +
                                            "- Don’t provide Company name\r\n" +
                                            "- Write the general attractive information, add link job on website or attach JD pdf file follow company format.\r\n" +
                                            "- Ask for CV when proper.\r\n" +
                                            "- Respect candidates needs, and ask";

                    break;
                case 3://Follow up interviews
                    ucTemplateEditText1.Tooltip = "Talk to candidate after the interview to check the process \r\n" +
                                            "- To understand which aspects went well/ not well and why\r\n" +
                                            "- To understand candidate’s view after the interview, if they still interested in the role, company, is there any reasons that they will accept the offer or not?\r\n" +
                                            "- Ask proper job and try to understand WHY.\r\n" +
                                            "- Noted and thanks\r\n" +
                                            "- Check with client about the interview and talk to candidate again.";

                    break;
                case 4://Interview confirmation
                    ucTemplateEditText1.Tooltip = "Email to candidate after confirm the date and time with both client and candidate via phone/chat.\r\n" +
                                            "- Send calendar to candidate, cc client contact point.Only send mobile phone when required.\r\n" +
                                            "- Set all information clear in calendar invitation.\r\n" +
                                            "- Ask for candidate’s confirmation\r\n" +
                                            "- Set notification 2 hour before the interview and call candidate to make sure they come on time.";

                    break;
                case 5://Meeting
                    ucTemplateEditText1.Tooltip = "Build rapport and trust\r\n" +
                                            "- Demonstrate in depth knowledge of the market\r\n" +
                                            "- Fully understand their reasons for leaving and what tempt them to stay.\r\n" +
                                            "- Continuously sell the features and benefits of the roles being discussed\r\n" +
                                            "- Open new direction of cooperation\r\n" +
                                            "- Ask for references\r\n" +
                                            "- Ask and listen more than speaking, but control the talk.\r\n" +
                                            "- Manage candidate’s expectation.";

                    break;
                case 6://Rejection
                    ucTemplateEditText1.Tooltip = "Notice candidate the rejection for a position.\r\n" +
                                            "- Keep good relationships\r\n" +
                                            "- Ask candidate to subscribe website\r\n" +
                                            "- Update all candidate’s information and activities to internal system.\r\n" +
                                            "- Keep tracking and send with proper job next time.";

                    break;
                case 7://Offering
                    ucTemplateEditText1.Tooltip = "Manage the offer: job title, salary/rate; Bonus, Benefits, Holidays; Reporting line; Start date, contract length; Contract (timing and delivery).\r\n" +
                                            "- Delivering offer\r\n" +
                                            "- Discuss about start date\r\n" +
                                            "- Advice on resignation\r\n" +
                                            "- Handling counter offer\r\n";
                    break;
                case 8://Placement register
                    ucTemplateEditText1.Tooltip = "Meet the candidate immediately after their resignation\r\n" +
                                            "- Remain in constant contact during their notice period\r\n" +
                                            "- Phone the candidate:\r\n" +
                                            "\t+ Before the start date to make sure they are in\r\n" +
                                            "\t+ On the 1st day in the new role\r\n" +
                                            "\t+ Ongoing basis(1/month)";

                    break;
                default:
                    break;
            }

        }
    }
}