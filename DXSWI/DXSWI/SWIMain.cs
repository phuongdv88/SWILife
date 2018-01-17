﻿using System;
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
using System.Reflection;
using System.IO;

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
            string tag = tagCompanies;

            foreach (RibbonPage page in ribbonControlMain.Pages)
            {
                string page_tag = page.Tag.ToString();
                if (!string.IsNullOrEmpty(page_tag))
                {
                    if (page_tag.Equals(tag))
                    {
                        ribbonControlMain.SelectedPage = page;
                    }
                }
            }
            changeGroup(tag);
        }


        public SWIMain()
        {
            InitializeComponent();
        }

        public void SetupUiByRole()
        {
            if(UserManager._ActivatedUser != null)
            {
                if(UserManager._ActivatedUser.RoleName != "ADMIN")
                {
                    rpgEditUser.Visible = false;
                } else
                {
                    rpgEditUser.Visible = true;
                }
            }
            mfrUser.SetupUi();

        }

        private void initializeTheme()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = Properties.Settings.Default.Theme.ToString();
        }

        private void SWIMain_Load(object sender, EventArgs e)
        {
            initializeTheme();
            init();
            // show version
            DateTime buildDate = new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime;
            //Text = string.Format("SWILIFE HR Assistant - Version {0} - Build time: {1}", Assembly.GetExecutingAssembly().GetName().Version.ToString(), buildDate.ToString("dd/MM/yyy hh:mm:ss"));
            Text = string.Format("SWILIFE HR Assistant - Version {0} - Build time: {1}", Application.ProductVersion, buildDate.ToString("dd/MM/yyy hh:mm:ss"));

        }

        private void skinRibbonGalleryBarItem1_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            if (e == null)
                return;
            Properties.Settings.Default.Theme = e.Item.Caption.ToString();
            Properties.Settings.Default.Save();
        }

        private void SWIMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            if (XtraMessageBox.Show("Are you sure to want to quit?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    SWIBLL.UserManager.Logout();
                    ScreenManager.Instance.quit();
                }
                catch { }
            }
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
                if (SWIBLL.UserManager.Logout())
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
            string tag = e.Group.Tag.ToString();
            foreach (RibbonPage page in ribbonControlMain.Pages)
            {
                string page_tag = page.Tag.ToString();
                if (!string.IsNullOrEmpty(page_tag))
                {
                    if (page_tag.Equals(tag))
                    {
                        ribbonControlMain.SelectedPage = page;
                    }
                }
            }

            changeGroup(e.Group.Tag.ToString());
        }
        private void changeGroup(string tag)
        {
            // change ribbon panel pages
            ////set invisible all ribbon control
            //foreach (RibbonPage page in ribbonControlMain.Pages)
            //{
            //    string page_tag = page.Tag.ToString();
            //    if (!string.IsNullOrEmpty(page_tag))
            //    {
            //        if (!page_tag.Equals(tag))
            //        {
            //            page.Visible = false;
            //        }
            //        else
            //        {
            //            page.Visible = true;
            //        }
            //    }
            //}

            //// select the first visible ribbon page
            //foreach (RibbonPage page in ribbonControlMain.Pages)
            //{
            //    if (page.Visible)
            //    {
            //        ribbonControlMain.SelectedPage = page;
            //        break;
            //    }
            //}

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

        private void bbiUserAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            // add new user
            mfrUser.NewUser();
        }

        private void bbiUserEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            // edit current user
            mfrUser.EditUser();
        }

        private void bbiUserDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            // delete selected user
            mfrUser.DeleteUser();
            
        }

        private void bbiUserHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("This app was writed by PhuongDV for internal process in swifamily's company.");
        }

        private void bbiAddCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            // add company
            mfrCompanies.newCompany();
        }

        private void bbiEditCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            mfrCompanies.editCompany();
        }

        private void bbiDeleteCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            mfrCompanies.deleteCompany();
        }

        private void ribbonControlMain_SelectedPageChanged(object sender, EventArgs e)
        {
            changeGroup(ribbonControlMain.SelectedPage.Tag.ToString());
        }

        private void bbiAddJobOrder0_ItemClick(object sender, ItemClickEventArgs e)
        {
            mfrJobOrder.newJobOrder();
        }

        private void bbiEditJobOrder0_ItemClick(object sender, ItemClickEventArgs e)
        {
            mfrJobOrder.EditJobOrder();
        }

        private void bbiDeleteJobOrder0_ItemClick(object sender, ItemClickEventArgs e)
        {
            mfrJobOrder.deleteJobOrder();
        }

        private void barButtonItem1_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            mfrContacts.NewContact();
            
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            mfrContacts.EditContact();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            mfrContacts.DeleteContact();
        }

        private void bbiUserChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            mfrUser.changePassword();
        }

        private void pcMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}