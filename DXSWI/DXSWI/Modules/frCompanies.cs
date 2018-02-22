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
using SWIBLL.Models;
using SWIBLL;
using DXSWI.Forms;
namespace DXSWI.Modules
{
    public partial class frCompanies : DevExpress.XtraEditors.XtraUserControl
    {
        public frCompanies()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            updateData();
        }

        private void updateData()
        {
            try
            {
                gcCompanies.DataSource = CompanyManager.getAllCompanies();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newCompany();
        }
        public void newCompany()
        {
            dlgCompanyEdit dlg = new dlgCompanyEdit(-1);
            dlg.UpdateDataEvent += updateData;
            dlg.ShowDialog();
        }

        public void newContact()
        {
            try
            {
                if (gvCompanies.SelectedRowsCount > 0)
                {
                    dlgContactEdit dlg = new dlgContactEdit(-1, null);

                    int row = gvCompanies.GetSelectedRows().First();
                    DataRow data_row = gvCompanies.GetDataRow(row);
                    string comName = data_row["Name"].ToString();
                    dlg.SetCompanyName(comName);
                    dlg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void newJobOrder()
        {
            try
            {
                if (gvCompanies.SelectedRowsCount > 0)
                {
                    dlgJobOrderEdit dlg = new dlgJobOrderEdit(-1);

                    int row = gvCompanies.GetSelectedRows().First();
                    DataRow data_row = gvCompanies.GetDataRow(row);
                    string comName = data_row["Name"].ToString();
                    dlg.SetCompanyName(comName);
                    dlg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editCompany();
        }
        public void editCompany()
        {
            try
            {
                if (gvCompanies.SelectedRowsCount > 0)
                {
                    int row = gvCompanies.GetSelectedRows().First();
                    DataRow data_row = gvCompanies.GetDataRow(row);
                    int comId = int.Parse(data_row["CompanyId"].ToString());
                    dlgCompanyEdit dlg = new dlgCompanyEdit(comId);
                    dlg.UpdateDataEvent += updateData;
                    dlg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //be careful: delete Contact, Job order, running task also
            deleteCompany();

        }
        public void deleteCompany()
        {
            if (gvCompanies.SelectedRowsCount > 0)
            {
                if (XtraMessageBox.Show("System will also delete all of Job orders, running tasks and contacts related to this company. Are you sure to delete this Job Order?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // delete this running task data
                        var rows = gvCompanies.GetSelectedRows();
                        foreach (var row in rows)
                        {
                            DataRow data_row = gvCompanies.GetDataRow(row);
                            long comId = int.Parse(data_row["CompanyId"].ToString());
                            CompanyManager.deleteCompany(comId);
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
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newContact();
        }

        private void addJobOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newJobOrder();
        }

        private void gcCompanies_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvCompanies.SelectedRowsCount > 0)
                {
                    int row = gvCompanies.GetSelectedRows().First();
                    DataRow data_row = gvCompanies.GetDataRow(row);
                    int comId = int.Parse(data_row["CompanyId"].ToString());
                    dlgCompanyEdit dlg = new dlgCompanyEdit(comId);
                    dlg.UpdateDataEvent += updateData;
                    dlg.setReadOnlyMode(true);
                    dlg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void viewWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GotoSite();
        }

        public void GotoSite()
        {
            try
            {
                if (gvCompanies.SelectedRowsCount > 0)
                {
                    int row = gvCompanies.GetSelectedRows().First();
                    DataRow data_row = gvCompanies.GetDataRow(row);
                    string link = data_row["WebSite"].ToString();
                    if (!link.Contains("http"))
                    {
                        link = "https://" + link;
                    }
                    System.Diagnostics.Process.Start(link);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
