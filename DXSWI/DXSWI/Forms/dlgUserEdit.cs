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
    public partial class dlgUserEdit : DevExpress.XtraEditors.XtraForm
    {
        public delegate void onUpdateData();
        public event onUpdateData UpdateDataEvent;
        User _currentUser;
        bool _isNew = true;

        public dlgUserEdit(long UserId)
        {
            InitializeComponent();
            _currentUser = GetUserInfo(UserId);
            FillObjectToUi();
        }

        private User GetUserInfo(long UserId)
        {
            if (UserId < 0) return null;
            return UserManager.GetUser(UserId);
        }

        private void FillObjectToUi()
        {
            if (_currentUser != null)
            { 
                // edit
                textEditUserName.Text = _currentUser.UserName;
                comboBoxEditRole.EditValue = _currentUser.RoleName;
                Text = _currentUser.UserName;
                sbOk.Text = "Update";
                _isNew = false;
                
            }
            else
            {
                // new
                sbOk.Text = "Create";
                layoutControlItem2.Text = "Password";
                _isNew = true;
                checkEditChangePassword.Checked = true;
                checkEditChangePassword.Enabled = false;
            }
        }

        private bool ValidateUiData()
        {
            try
            {
                textEditUserName.Text = textEditUserName.Text.Trim();
                textEditPassword.Text = textEditPassword.Text.Trim();
                if (textEditUserName.Text.Length == 0)
                {
                    textEditUserName.Focus();
                    throw new Exception("User name cannot be blank!");
                }
                if (textEditPassword.Text.Length == 0 && _isNew)
                {
                    textEditPassword.Focus();
                    throw new Exception("Password cannot be blank!");
                }
                if (comboBoxEditRole.Text.Length == 0)
                {
                    comboBoxEditRole.Focus();
                    throw new Exception("Role cannot be blank!");
                }
               
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void getObjectFromUi()
        {
            


            if (_currentUser == null)
            {
                _currentUser = new User();
            }
            _currentUser.UserName = textEditUserName.Text;
            if (checkEditChangePassword.Checked && textEditPassword.Text.Length > 0)
            {
                // set new password
                _currentUser.Salt = Utils.getRandomAlphaNumeric(10);
                _currentUser.Password = UserManager.createMD5Hash(textEditPassword.Text.Trim() + _currentUser.Salt);

            }
            _currentUser.Role = comboBoxEditRole.SelectedIndex + 1;

        }
        private void dlgUserEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    sbOk.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void sbOk_Click(object sender, EventArgs e)
        {
            //todo validate data
            if (!ValidateUiData()) return;
            // update user
            try
            {
                getObjectFromUi();
                if (_isNew)
                {
                    UserManager.InsertUser(_currentUser);
                }
                else
                {
                    UserManager.UpdateUser(_currentUser);
                }
                UpdateDataEvent?.Invoke();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();

        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChangePassword.Checked)
            {
                textEditPassword.Enabled = true;
            }
            else
            {
                textEditPassword.Enabled = false;
            }
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}