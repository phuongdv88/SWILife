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
            // open dialog dlgJobOrderEdit
            dlgJobOrderEdit dlg = new dlgJobOrderEdit(-1);
            dlg.emitUpdateData += updateData;
            dlg.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int jobOrderId = -1;
            if (gvJobOrder.SelectedRowsCount > 0)
            {
                jobOrderId = int.Parse(gvJobOrder.GetDataRow(gvJobOrder.GetSelectedRows().First())["JobOrderId"].ToString());
            }
            dlgJobOrderEdit dlg = new dlgJobOrderEdit(jobOrderId);
            dlg.emitUpdateData += updateData;
            dlg.ShowDialog();
        }

        private void gvJobOrder_DoubleClick(object sender, EventArgs e)
        {
            editToolStripMenuItem_Click(sender, e);
        }
    }
}
