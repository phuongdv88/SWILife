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
using DevExpress.Utils;

namespace DXSWI.Controls
{
    public partial class ucTemplateEditText : DevExpress.XtraEditors.XtraUserControl
    {
        public string Tooltip { get; set; }
        public ucTemplateEditText()
        {
            InitializeComponent();
        }

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            string key = "Test";
            e.Info = new ToolTipControlInfo(key, Tooltip);
        }
    }
}
