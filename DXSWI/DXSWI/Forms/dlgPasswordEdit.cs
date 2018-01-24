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
    public partial class dlgPasswordEdit : DevExpress.XtraEditors.XtraForm
    {
        public dlgPasswordEdit()
        {
            InitializeComponent();
        }

        private void dlgPasswordEdit_KeyDown(object sender, KeyEventArgs e)
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
            try
            {
                if (textEditOld.Text.Length == 0)
                {
                    textEditOld.Focus();
                    throw new Exception("This field can not be blank!");
                }
                if (textEditNew.Text.Length == 0)
                {
                    textEditNew.Focus();
                    throw new Exception("This field can not be blank!");
                }

                if (textEditConfirm.Text.Length == 0)
                {
                    textEditConfirm.Focus();
                    throw new Exception("This field can not be blank!");
                }

                // check old password;
                if (!UserManager.verifyMd5Hash(textEditOld.Text.Trim() + UserManager.ActivatedUser.Salt, UserManager.ActivatedUser.Password))
                {
                    textEditOld.Focus();
                    textEditOld.Text = string.Empty;
                    textEditNew.Text = string.Empty;
                    textEditConfirm.Text = string.Empty;
                    throw new Exception("Old password is not correct!");
                }

                if (textEditConfirm.Text != textEditNew.Text)
                {
                    textEditNew.Focus();
                    textEditNew.Text = string.Empty;
                    textEditConfirm.Text = string.Empty;
                    throw new Exception("Confirm password is not match");
                }
                UserManager.ActivatedUser.Salt = Utils.getRandomAlphaNumeric(10);
                UserManager.ActivatedUser.Password = UserManager.createMD5Hash(textEditNew.Text.Trim() + UserManager.ActivatedUser.Salt);
                UserManager.UpdateUser(UserManager.ActivatedUser);

                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dlgPasswordEdit_Load(object sender, EventArgs e)
        {
            Text = UserManager.ActivatedUser.UserName;
            lcUserName.Text = Text;
            textEditOld.Focus();
        }

        private void textEditOld_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}