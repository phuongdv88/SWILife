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
using SWIBLL;
using SWIBLL.Models;
namespace DXSWI.Forms
{
    public partial class dlgSaveSmsTemplate : DevExpress.XtraEditors.XtraForm
    {
        private string _sms;
        public dlgSaveSmsTemplate(string sms)
        {
            InitializeComponent();
            _sms = sms;
        }

        private void dlgSaveSmsTemplate_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    sbSave.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            // save to db
            if(teTitle.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("This field can not be empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try {
                SmsTemplate tmp = new SmsTemplate()
                {
                    Title = teTitle.Text.Trim(),
                    Message = _sms
                };
                SmsManager.InsertSmsTemplate(tmp);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }
    }
}