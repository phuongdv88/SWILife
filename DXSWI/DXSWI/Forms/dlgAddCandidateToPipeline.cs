﻿using System;
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
            try
            {

                //get current selection object
                if (gvCandidates.SelectedRowsCount > 0)
                {
                    int row = gvCandidates.GetSelectedRows().First();
                    DataRow data_row = gvCandidates.GetDataRow(row); // for test
                    int CandidateId = int.Parse(data_row["CandidateId"].ToString());

                    if(RunningTaskManager.isExist(CandidateId, jobId))
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

        private void gcCandidates_DoubleClick(object sender, EventArgs e)
        {
            int canId = -1;
            if (gvCandidates.SelectedRowsCount > 0)
            {
                canId = int.Parse(gvCandidates.GetDataRow(gvCandidates.GetSelectedRows().First())["CandidateId"].ToString());
            }
            if (canId == -1)
                return;
            // todo show dlgCandidateEdit but in mode view only
            dlgCandidateEdit dlg = new dlgCandidateEdit(canId, null);
            dlg.setViewMode();
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
    }
}