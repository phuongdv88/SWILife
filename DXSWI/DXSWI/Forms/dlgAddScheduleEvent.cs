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

namespace DXSWI.Forms
{
    public partial class dlgAddScheduleEvent : DevExpress.XtraEditors.XtraForm
    {
        public dlgAddScheduleEvent()
        {
            InitializeComponent();
        }

        private void dlgAddScheduleEvent_KeyDown(object sender, KeyEventArgs e)
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