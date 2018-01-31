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
using SWIBLL.Models;
using SWIBLL;
using System.Collections;

namespace DXSWI.Forms
{
    public partial class dlgJobOrderReport : DevExpress.XtraEditors.XtraForm
    {
        long _jobOrderId = -1;
        public dlgJobOrderReport(JobOrder jobOrder)
        {
            InitializeComponent();
            _jobOrderId = jobOrder.JobOrderId;
            Text = jobOrder.Title;
            init();
        }

        private void init()
        {
            List<ReportJobOrder> rps = JobOrderManager.GetReport(_jobOrderId);
            ccMain.DataSource = rps;
        }
    }
}