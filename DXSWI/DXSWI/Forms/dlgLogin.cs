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
using System.Security.Cryptography;
using SWIBLL;

namespace DXSWI.Forms
{
    public partial class dlgLogin : DevExpress.XtraEditors.XtraForm
    {
        bool _isInputPassword = false;
        public dlgLogin()
        {
            InitializeComponent();

            textEditUserName.Text = Properties.Settings.Default.UserName;
            textEditPassword.Text = Properties.Settings.Default.HashPassword.Length > 0 ? "******" : "";
            _isInputPassword = false;
            try
            {
                UserManager.ConnectoDB(Properties.Settings.Default.SwilifecoreConnectionString);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }


        }

        private bool validateInput()
        {
            try
            {
                if (textEditUserName.Text.Length == 0)
                {
                    throw new Exception("User name must not be blank!");
                }
                if (textEditPassword.Text.Length == 0)
                {
                    throw new Exception("Password must not be blank!");
                }
            }
            catch (Exception ex)
            {
                clearUiData();
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void sbLogin_Click(object sender, EventArgs e)
        {
            if (!validateInput()) return;
            try
            {

                // get salt by user name
                string salt = UserManager.GetSaltByUserName(textEditUserName.Text.Trim());
                if (salt == null)
                {
                    throw new Exception("User name or password is incorrect!");
                }
                // gen password
                string hashPassword = Properties.Settings.Default.HashPassword;

                if (_isInputPassword)
                {
                    hashPassword = UserManager.createMD5Hash(textEditPassword.Text + salt);
                }
                //login
                if (UserManager.Login(textEditUserName.Text, hashPassword))
                {
                    // if login successfully, save username and hash password if necessary
                    if (checkEditRememberMe.Checked)
                    {
                        Properties.Settings.Default.UserName = textEditUserName.Text;
                        Properties.Settings.Default.HashPassword = hashPassword;
                    }
                    else
                    {
                        Properties.Settings.Default.UserName = "";
                        Properties.Settings.Default.HashPassword = "";
                    }

                    Properties.Settings.Default.Save();
                    //show main window
                    ScreenManager.Instance.ShowMainScreen();
                }
                else
                {
                    textEditUserName.Focus();
                    throw new Exception("Can not login!");
                }
            }
            catch (Exception ex)
            {
                clearUiData();
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearUiData()
        {
            textEditUserName.Focus();
            textEditUserName.Text = "";
            textEditPassword.Text = "";
        }
        public void logout()
        {
            if (!checkEditRememberMe.Checked)
            {
                clearUiData();
            }
        }

        private void dlgLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    sbLogin.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void dlgLogin_Load(object sender, EventArgs e)
        {

        }

        private void textEditPassword_EditValueChanged(object sender, EventArgs e)
        {
            _isInputPassword = true;
        }

        private void textEditPassword_Enter(object sender, EventArgs e)
        {
            textEditPassword.SelectAll();
        }

        private void textEditUserName_Enter(object sender, EventArgs e)
        {
            textEditUserName.SelectAll();
        }
    }
}
