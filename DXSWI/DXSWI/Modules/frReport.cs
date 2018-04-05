﻿using System;
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
    public partial class frReport : DevExpress.XtraEditors.XtraUserControl
    {
        public frReport()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            bbiStartDate.EditValue = DateTime.Now.AddDays(-30);
            bbiStopDate.EditValue = DateTime.Now;

            updateAllActivitiesData();
            updateChartData();
            updateReportData();
            updateUserReportData();
            
        }
        /// <summary>
        /// get late 1000 activities
        /// </summary>
        private async void updateAllActivitiesData()
        {
            try
            {
                gcActivites.DataSource = await ActivityManager.getAllActivitiesAsync();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateChartData()
        {
            try
            {
                ccWeeklyReport.DataSource = JobOrderManager.GetReportByWeek();
                ccMonthlyReport.DataSource = JobOrderManager.GetReportByMonth();
                ccYearlyReport.DataSource = JobOrderManager.GetReportByYear();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// get report data about 4 last months
        /// </summary>
        private void updateReportData()
        {
            try
            {
                gcReports.DataSource = UserManager.getReportByMonth();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// get report data by user in last 30 days
        /// </summary>
        private void updateUserReportData()
        {
            try
            {
                gcUserReports.DataSource = UserManager.getReportUserByDate(DateTime.Parse(bbiStartDate.EditValue.ToString()), DateTime.Parse(bbiStopDate.EditValue.ToString()));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            updateUserReportData();
        }

        private void gvActivities_DoubleClick(object sender, EventArgs e)
        {
            // view activity
            try
            {
                if (gvActivities.SelectedRowsCount > 0)
                {
                    DataRow data_row = gvActivities.GetDataRow(gvActivities.GetSelectedRows().First());
                    long activity_id = Convert.ToInt64(data_row["ActivityId"].ToString());
                    dlgLogActivity dlg = new dlgLogActivity();
                    dlg.setData(activity_id);
                    dlg.SetReadingMode();
                    dlg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
