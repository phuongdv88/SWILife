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
    public partial class dlgAddCandidateToPipeline : DevExpress.XtraEditors.XtraForm
    {
        public delegate void updateData();
        public event updateData updateDataEvent;
        long jobId = -1;
        public dlgAddCandidateToPipeline(long jobOrderId)
        {
            InitializeComponent();
            jobId = jobOrderId;
            init();
        }

        private void init()
        {
            try
            {
                // load data in candidate table and show in grid control
                gcCandidates.DataSource = CandidateManager.getCandidatesOverview();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            InsertCandidates();
        }

        private void InsertCandidates()
        {

            //multi insert
            if (gvCandidates.SelectedRowsCount > 0)
            {
                var rows = gvCandidates.GetSelectedRows();
                foreach (var row in rows)
                {
                    try
                    {
                        DataRow data_row = gvCandidates.GetDataRow(row); // for test
                        int CandidateId = int.Parse(data_row["CandidateId"].ToString());

                        if (RunningTaskManager.isExist(CandidateId, jobId))
                        {
                            throw new Exception("It has already in Pipeline!");
                        }

                        // add to running task table
                        RunningTask rtask = new RunningTask
                        {
                            CandidateId = CandidateId,
                            JobOrderId = jobId,
                            Added = DateTime.Now,
                            EnteredBy = UserManager.ActivatedUser?.UserName
                        };

                        RunningTaskManager.createRunningTask(rtask);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // emit to update data
                updateDataEvent?.Invoke();
            }

        }
        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gcCandidates_DoubleClick(object sender, EventArgs e)
        {
            long canId = -1;
            if (gvCandidates.SelectedRowsCount > 0)
            {
                canId = Convert.ToInt64(gvCandidates.GetDataRow(gvCandidates.GetSelectedRows().First())["CandidateId"].ToString());
            }
            if (canId == -1)
                return;
            // todo show dlgCandidateEdit but in mode view only
            dlgCandidateEdit dlg = new dlgCandidateEdit(canId, null);
            //dlg.setViewMode();
            dlg.ShowDialog();
        }

        private void dlgAddCandidateToPipeline_KeyDown(object sender, KeyEventArgs e)
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

        private void copyEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                //get current selection object
                if (gvCandidates.SelectedRowsCount > 0)
                {
                    int row = gvCandidates.GetSelectedRows().First();
                    DataRow data_row = gvCandidates.GetDataRow(row); // for test
                    Clipboard.SetText(data_row["Email"].ToString());
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gcCandidates_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sbOK.PerformClick();
            } else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}