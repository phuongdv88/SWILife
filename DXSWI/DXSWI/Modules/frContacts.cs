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
using SWIBLL;
using SWIBLL.Models;
using DXSWI.Forms;
namespace DXSWI.Modules
{
    public partial class frContacts : DevExpress.XtraEditors.XtraUserControl
    {
        public frContacts()
        {
            InitializeComponent();
            //init();
        }

        public void init()
        {
            updateData();
        }

        private void updateData()
        {
            try
            {
                gcContacts.DataSource = ContactManager.getContacts();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewContact();
        }

        public void NewContact()
        {
            dlgContactEdit dlg = new dlgContactEdit(-1);
            dlg.emitUpdateData += updateData;
            dlg.ShowDialog();
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        public void EditContact()
        {
            try
            {
                
                if (gvContacts.SelectedRowsCount > 0)
                {
                    int row = gvContacts.GetSelectedRows().First();
                    DataRow data_row = gvContacts.GetDataRow(row);
                    long conId = Convert.ToInt64(data_row["ContactId"].ToString());
                    dlgContactEdit dlg = new dlgContactEdit(conId);
                    dlg.emitUpdateData += updateData;
                    dlg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        public void DeleteContact()
        {
            if (XtraMessageBox.Show("Are you sure to delete this Contact?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // delete this running task data
                    if (gvContacts.SelectedRowsCount > 0)
                    {
                        var rows = gvContacts.GetSelectedRows();
                        foreach (var row in rows)
                        {
                            DataRow data_row = gvContacts.GetDataRow(row);
                            long conId = Convert.ToInt64(data_row["ContactId"].ToString());
                            ContactManager.DeleteContact(conId);
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    updateData();
                }
            }
        }


        private void gcContacts_DoubleClick(object sender, EventArgs e)
        {
            EditContact();
        }

        private void frContacts_Load(object sender, EventArgs e)
        {
            init();
        }

        private void refreshContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateData();
        }
    }
}
