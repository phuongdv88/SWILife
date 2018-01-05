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
using System.ComponentModel.DataAnnotations;
using SWIBLL.Models;
using SWIBLL;
using DXSWI.Forms;

namespace DXSWI.Modules
{
    public partial class frUser : DevExpress.XtraEditors.XtraUserControl
    {
        public frUser()
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
                gcUser.DataSource = UserManager.getAllUsers();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
