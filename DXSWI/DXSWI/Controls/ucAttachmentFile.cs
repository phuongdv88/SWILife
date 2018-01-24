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

namespace DXSWI.Controls
{
    public partial class ucAttachmentFile : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void deleteFileName();
        public deleteFileName deleteFileNameEvent;
        public ucAttachmentFile(string fileName)
        {
            InitializeComponent();
            lciName.Text = fileName;
        }

        private void sbDelete_Click(object sender, EventArgs e)
        {
            deleteFileNameEvent?.Invoke();
        }
    }
}
