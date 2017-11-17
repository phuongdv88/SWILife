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
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;

namespace DXSWI
{
    public partial class SWIMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SWIMain()
        {
            InitializeComponent();
        }

        private void initializeTheme()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = Properties.Settings.Default.theme.ToString();
        }

        private void SWIMain_Load(object sender, EventArgs e)
        {
            initializeTheme();
        }

        private void skinRibbonGalleryBarItem1_GalleryItemCheckedChanged(object sender, DevExpress.XtraBars.Ribbon.GalleryItemEventArgs e)
        {
            //if (e == null)
            //    return;
            //Properties.Settings.Default.theme = e.Item.Caption.ToString();
        }

        private void skinRibbonGalleryBarItem1_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            if (e == null)
                return;
            Properties.Settings.Default.theme = e.Item.Caption.ToString();
            Properties.Settings.Default.Save();
        }

        private void SWIMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to want to quit?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            try
            {
                SWIBLL.UserManager.logout();
                ScreenManager.Instance.quit();
            }
            catch { }
        }

        private void SWIMain_KeyDown(object sender, KeyEventArgs e)
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

        private void barBILogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to want to logout?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            try
            {
                if (SWIBLL.UserManager.logout())
                {
                    ScreenManager.Instance.showLoginScreen();
                }
                else
                {
                    XtraMessageBox.Show("Can not logout!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
        }

        private void navBarControl1_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            //object data = GetModuleData((NavBarGroupTagObject)e.Group.Tag);
        }

        //protected object GetModuleData(NavBarGroupTagObject tag)
        //{
        //    if (tag == null) return null;
        //    if (tag.ModuleType == typeof(DevExpress.MailClient.Win.Calendar)) return ucCalendar1;
        //    if (tag.ModuleType == typeof(DevExpress.MailClient.Win.Feeds)) return navBarControl2;
        //    if (tag.ModuleType == typeof(DevExpress.MailClient.Win.Tasks)) return nbgTasks;
        //    return null;
        //}
    }
}