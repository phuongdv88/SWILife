using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using SWIBLL.Models;
using SWIBLL;
using DXSWI.Forms;

namespace DXSWI.Modules
{
    public partial class frUser : DevExpress.XtraEditors.XtraUserControl
    {
        public frUser()
        {
            InitializeComponent();
        }

        public void init()
        {
            // 5s update 1 lan
            Timer aTimer = new Timer();
            aTimer.Tick += OnTimedEvent;
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
            updateData();
        }

        public void SetupUi()
        {
            if (UserManager._ActivatedUser != null)
            {
                if (UserManager._ActivatedUser.RoleName != "ADMIN")
                {
                    gcUser.ContextMenuStrip = null;
                }
                else
                {
                    gcUser.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }

        private void updateData()
        {
            try
            {
                int row = -1;
                if (gvUser.SelectedRowsCount > 0)
                {
                    row = gvUser.GetSelectedRows().First();
                }
                gcUser.DataSource = UserManager.GetAllUsers();
                if (row != -1 && row < gvUser.RowCount)
                {
                    gvUser.ClearSelection();
                    gvUser.SelectRow(row);
                    gvUser.FocusedRowHandle = row;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frUser_Load(object sender, EventArgs e)
        {
            init();
        }

        private void OnTimedEvent(object source, EventArgs e)
        {
            updateData();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser();
        }

        public void NewUser()
        {
            dlgUserEdit dlg = new dlgUserEdit(-1);
            dlg.UpdateDataEvent += updateData;
            dlg.ShowDialog();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        public void EditUser()
        {
            if (gvUser.SelectedRowsCount > 0)
            {
                try
                {
                    // delete this running task data
                    int row = gvUser.GetSelectedRows().First();
                    DataRow data_row = gvUser.GetDataRow(row);
                    int UserId = int.Parse(data_row["UserId"].ToString());

                    dlgUserEdit dlg = new dlgUserEdit(UserId);
                    dlg.UpdateDataEvent += updateData;
                    dlg.ShowDialog();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void changePassword()
        {
            dlgPasswordEdit dlg = new dlgPasswordEdit();
            dlg.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        public void DeleteUser()
        {
            if (UserManager._ActivatedUser.RoleName != "ADMIN")
                return;
            if (gvUser.SelectedRowsCount > 0)
            {
                if (XtraMessageBox.Show("Are you sure to delete this account?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // delete this running task data
                        int row = gvUser.GetSelectedRows().First();
                        DataRow data_row = gvUser.GetDataRow(row);
                        long UserId = Convert.ToInt64(data_row["UserId"].ToString());
                        bool isOnline = Convert.ToBoolean(int.Parse(data_row["IsOnline"].ToString()));
                        if(UserId == UserManager._ActivatedUser.UserId || isOnline)
                        {
                            throw new Exception("This account is online!");
                        }
                        UserManager.DeleteUser(UserId);
                        updateData();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gvUser_DoubleClick(object sender, EventArgs e)
        {
            editUserToolStripMenuItem.PerformClick();
        }
    }
}
