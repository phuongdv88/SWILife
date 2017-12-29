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
            updateData();
        }

        private void updateData()
        {
            try
            {
                gcActivites.DataSource = ActivityManager.getAllActivities();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
