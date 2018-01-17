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

namespace DXSWI.Forms
{
    public partial class dlgChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public dlgChangePassword()
        {
            InitializeComponent();
        }

        private void dlgChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    sbOK.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validateUi()
        {
            try
            {
                if (textEditOld.Text.Length == 0)
                {
                    textEditOld.Focus();
                    throw new Exception("Old password can not be blank!");
                }
                if (textEditNew.Text.Length == 0)
                {
                    textEditNew.Focus();
                    throw new Exception("New password can not be blank!");
                }

                if (textEditConfirm.Text.Length == 0)
                {
                    textEditConfirm.Focus();
                    throw new Exception("Confirm password can not be blank!");
                }

                if (textEditConfirm.Text != textEditNew.Text)
                {
                    textEditNew.Text = string.Empty;
                    textEditConfirm.Text = string.Empty;
                    textEditNew.Focus();
                    throw new Exception("Confirm password is not match");
                }
                // check old password;
                if (!UserManager.verifyMd5Hash(textEditOld.Text.Trim() + UserManager._ActivatedUser.Salt, UserManager._ActivatedUser.Password))
                {
                    textEditOld.Focus();
                    clearUi();
                    throw new Exception("Old password is incorrect!");
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void clearUi()
        {
            textEditOld.Text = string.Empty;
            textEditNew.Text = string.Empty;
            textEditConfirm.Text = string.Empty;
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            if (!validateUi()) return;
            try
            {
                // check old password;
                if (!UserManager.verifyMd5Hash(textEditOld.Text.Trim() + UserManager._ActivatedUser.Salt, UserManager._ActivatedUser.Password))
                {
                    throw new Exception("Old password is incorrect!");
                }

                UserManager._ActivatedUser.Salt = Utils.getRandomAlphaNumeric(10);
                UserManager._ActivatedUser.Password = UserManager.createMD5Hash(textEditNew.Text.Trim() + UserManager._ActivatedUser.Salt);
                UserManager.UpdateUser(UserManager._ActivatedUser);

                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dlgChangePassword_Load(object sender, EventArgs e)
        {
            Text = UserManager._ActivatedUser.UserName;
            textEditOld.Focus();
        }
    }
}