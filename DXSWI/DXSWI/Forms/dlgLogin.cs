﻿using System;
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
        public dlgLogin()
        {
            InitializeComponent();

            textEditUserName.Text = Properties.Settings.Default.userName;
            textEditPassword.Text = Properties.Settings.Default.password.Length > 0 ? "******" : "";
            string connection_string = Properties.Settings.Default.swilifecoreConnectionString;
            try
            {
                UserManager.connectoDB(connection_string);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }


        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private string createMD5Hash(string input_string)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash_bytes = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(input_string));
                //convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash_bytes.Length; ++i)
                {
                    sb.Append(hash_bytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private bool verifyMd5Hash(string input, string hash)
        {
            string hashOfInput = createMD5Hash(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            return false;

        }


        private void sbLogin_Click(object sender, EventArgs e)
        {
            //validate input

            // gen password
            string salt = "123456a@";
            string hashPassword = Properties.Settings.Default.password;
            if (hashPassword.Length == 0)
            {
                hashPassword = createMD5Hash(textEditPassword.Text + salt);
            }
            try
            {
                //login
                if (UserManager.login(textEditUserName.Text, hashPassword))
                {
                    // if login successfully, save username and hash password if necessary
                    if (checkEditRememberMe.Checked == true)
                    {
                        Properties.Settings.Default.userName = textEditUserName.Text;
                        Properties.Settings.Default.password = hashPassword;
                    }
                    else
                    {
                        Properties.Settings.Default.userName = "";
                        Properties.Settings.Default.password = "";
                    }

                    Properties.Settings.Default.Save();
                    //show main window
                    ScreenManager.Instance.showMainScreen();
                    //XtraMessageBox.Show("login successfully!", textEditUserName.Text);
                } else
                {
                    XtraMessageBox.Show("Can not login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textEditUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEditUserName.Focus();
                textEditUserName.Text = "";
                textEditPassword.Text = "";
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
    }
}
