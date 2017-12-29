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
using DXSWI;

namespace DXSWI.Forms
{
    public partial class dlgAddJobOrderToPipeline : DevExpress.XtraEditors.XtraForm
    {
        public delegate void updateData();
        public event updateData updateDataEvent;
        long canId = -1;
        public dlgAddJobOrderToPipeline(long candidateId)
        {
            InitializeComponent();
            init();
            canId = candidateId;
        }
        public void init()
        {
            // get all joborders link with company
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
        private void sbAdd_Click(object sender, EventArgs e)
        {
            try
            {

                //get current selection object
                if (gvJobOrder.SelectedRowsCount > 0)
                {
                    int row = gvJobOrder.GetSelectedRows().First();
                    DataRow data_row = gvJobOrder.GetDataRow(row); // for test
                    int jobId = int.Parse(data_row["JobOrderId"].ToString());

                    if (RunningTaskManager.isExist(canId, jobId))
                    {
                        throw new Exception("It has already in Pipeline!");
                    }

                    // add to running task table
                    RunningTask rtask = new RunningTask { CandidateId = canId, 
                                                        JobOrderId = jobId,
                    Added = DateTime.Now,
                    EnteredBy = UserManager.ActivatedUser?.UserName};
                    
                    RunningTaskManager.createRunningTask(rtask);
                    // emit to update data
                    updateDataEvent?.Invoke();
                }                
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

        private void dlgAddJobOrderToPipeline_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}