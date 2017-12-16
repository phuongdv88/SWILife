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
using DXSWI.Modules;
using DXSWI.Forms;
using DevExpress.XtraBars.Ribbon;
using SWIBLL;
using SWIBLL.Models;

namespace DXSWI
{
    public partial class SWIMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frCalendar mfrCalendar = new frCalendar();
        readonly string tagCalendar = "calendar";
        frCandidates mfrCandidate = new frCandidates();
        readonly string tagCandidates = "candidate";
        frCompanies mfrCompanies = new frCompanies();
        readonly string tagCompanies = "company";
        frContacts mfrContacts = new frContacts();
        readonly string tagContacts = "contact";
        frJobOrders mfrJobOrder = new frJobOrders();
        readonly string tagJobOrder = "joborder";
        frReport mfrReport = new frReport();
        readonly string tagReport = "report";
        frUser mfrUser = new frUser();
        readonly string tagUser = "user";
        frUtilities mfrUtilities = new frUtilities();
        readonly string tagUtilities = "utility";

        void init()
        {
            // init all Modules
            changeGroup(tagCandidates);
        }


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
            init();

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
            if (e.Group.Tag == null)
                return;
            changeGroup(e.Group.Tag.ToString());
        }
        private void changeGroup(string tag)
        {
            // change ribbon panel pages
            //set invisible all ribbon control
            foreach (RibbonPage page in ribbonControlMain.Pages)
            {
                string page_tag = page.Tag.ToString();
                if (!string.IsNullOrEmpty(page_tag))
                {
                    if (!page_tag.Equals(tag))
                    {
                        page.Visible = false;
                    }
                    else
                    {
                        page.Visible = true;
                    }
                }
            }

            // select the first visible ribbon page
            foreach (RibbonPage page in ribbonControlMain.Pages)
            {
                if (page.Visible)
                {
                    ribbonControlMain.SelectedPage = page;
                    break;
                }
            }



            // change pcMain
            if (tag.Equals(tagCandidates))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(mfrCandidate);
                mfrCandidate.Dock = DockStyle.Fill;
            }
            if (tag.Equals(tagCalendar))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(mfrCalendar);
                mfrCalendar.Dock = DockStyle.Fill;
            }
            if (tag.Equals(tagCompanies))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(mfrCompanies);
                mfrCompanies.Dock = DockStyle.Fill;
            }
            if (tag.Equals(tagContacts))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(mfrContacts);
                mfrContacts.Dock = DockStyle.Fill;
            }
            if (tag.Equals(tagJobOrder))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(mfrJobOrder);
                mfrJobOrder.Dock = DockStyle.Fill;
            }
            if (tag.Equals(tagReport))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(mfrReport);
                mfrReport.Dock = DockStyle.Fill;
            }
            if (tag.Equals(tagUser))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(mfrUser);
                mfrUser.Dock = DockStyle.Fill;
            }
            if (tag.Equals(tagUtilities))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(mfrUtilities);
                mfrUtilities.Dock = DockStyle.Fill;
            }
        }

        private void navBarControl1_CustomDrawLink(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs e)
        {
            if (e.Caption == nbgCandidates.Caption)
                e.Graphics.FillRectangle(Brushes.Red, e.RealBounds);
        }

        private void bbiCandidatesEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            mfrCandidate.editToolStripMenuItem_Click(sender, e);
        }

        private void bbiCandidatesCreate_ItemClick(object sender, ItemClickEventArgs e)
        {
            mfrCandidate.newToolStripMenuItem_Click(sender, e);
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            mfrCandidate.deleteToolStripMenuItem_Click(sender, e);
        }

        private void bbiCandidatesAddEvent_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiCandidatesAddAttachment_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void bbiCandidatesAddPipeline_ItemClick(object sender, ItemClickEventArgs e)
        {
            mfrCandidate.AddJobToPipeLine();
        }

        private void bbiCandidateLogActivity_ItemClick(object sender, ItemClickEventArgs e)
        {
            mfrCandidate.logActivity();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }
    }
}