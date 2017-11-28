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
    public partial class ucChangePageBar : DevExpress.XtraEditors.XtraUserControl
    {
        public int ItemCount { get; set; }

        int currentPage = 0 ;
        public int CurrentPage {
            get {
                return currentPage;
            }
            set
            {
                lcCurrentPage.Text = string.Format("Page {0}/{1}", ItemCount, currentPage);
            }
                 }
        public ucChangePageBar()
        {
            InitializeComponent();
        }

        private void sbPrevious_Click(object sender, EventArgs e)
        {

        }

        private void sbNext_Click(object sender, EventArgs e)
        {

        }

        private void sbLas_Click(object sender, EventArgs e)
        {

        }

        private void sbFirst_Click(object sender, EventArgs e)
        {

        }

        private void cbePageSize_TabIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
