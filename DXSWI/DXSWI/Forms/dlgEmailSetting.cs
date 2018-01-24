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

namespace DXSWI.Forms
{
    public partial class dlgEmailSetting : DevExpress.XtraEditors.XtraForm
    {
        public dlgEmailSetting()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            textEditEmailAccount.Text = Properties.Settings.Default.EmailAccount;
            textEditPassword.Text = Properties.Settings.Default.EmailPassword;
        }

        public void SetEmailAddress(string emailAddress)
        {
            textEditEmailAccount.Text = emailAddress;
            //textEditEmailAccount.ReadOnly = true;
        }

        private void dlgEmailSetting_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    sbUpdate.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void sbUpdate_Click(object sender, EventArgs e)
        {
            // validate data
            if(textEditEmailAccount.Text.Trim() == "")
            {
                textEditEmailAccount.Focus();
                XtraMessageBox.Show("Email can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textEditPassword.Text.Trim() == "")
            {
                textEditPassword.Focus();
                XtraMessageBox.Show("Email can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // save to setting info
            Properties.Settings.Default.EmailAccount = textEditEmailAccount.Text.Trim();
            Properties.Settings.Default.EmailPassword = textEditPassword.Text.Trim();
            Properties.Settings.Default.Save();

            Close();
        }
    }
}