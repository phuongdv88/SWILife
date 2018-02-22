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
using DXSWI.Forms;

namespace DXSWI.Modules
{
    public partial class frJobOrders : DevExpress.XtraEditors.XtraUserControl
    {
        public frJobOrders()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            updateData();
        }

        private void updateData()
        {
            try
            {
                // load data in candidate table and show in grid control
                gcJobOrder.DataSource = JobOrderManager.getJobOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newJobOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newJobOrder();
        }
        public void newJobOrder()
        {
            // open dialog dlgJobOrderEdit
            dlgJobOrderEdit dlg = new dlgJobOrderEdit(-1);
            dlg.UpdateDataEvent += updateData;
            dlg.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditJobOrder();
        }

        public void EditJobOrder()
        {
            long jobOrderId = -1;
            if (gvJobOrder.SelectedRowsCount > 0)
            {
                jobOrderId = Convert.ToInt64(gvJobOrder.GetDataRow(gvJobOrder.GetSelectedRows().First())["JobOrderId"].ToString());
            }
            dlgJobOrderEdit dlg = new dlgJobOrderEdit(jobOrderId);
            dlg.UpdateDataEvent += updateData;
            dlg.ShowDialog();
        }

        private void gvJobOrder_DoubleClick(object sender, EventArgs e)
        {
            editToolStripMenuItem_Click(sender, e);
        }

        private void deleteJobOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteJobOrder();
        }
        public void deleteJobOrder()
        {
            // delete this running task data
            if (gvJobOrder.SelectedRowsCount > 0)
            {
                if (XtraMessageBox.Show("System will also delete running task of this Job Order. Are you sure to delete this Job Order?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        var rows = gvJobOrder.GetSelectedRows();
                        foreach (var row in rows)
                        {
                            DataRow data_row = gvJobOrder.GetDataRow(row);
                            int jobOrderId = int.Parse(data_row["JobOrderId"].ToString());
                            JobOrderManager.deleteJobOrder(jobOrderId);
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
