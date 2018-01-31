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
using System.Reflection;
using System.IO;

namespace DXSWI
{
    public partial class SWIMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //frCalendar _frCalendar = new frCalendar();        
        //readonly string _tagCalendar = "calendar";

        frSchedule _frSchedule = new frSchedule();
        readonly string _tagSchedule = "schedule";
        frCandidates _frCandidate = new frCandidates();
        readonly string _tagCandidates = "candidate";
        frCompanies _frCompanies = new frCompanies();
        readonly string _tagCompanies = "company";
        frContacts _frContacts = new frContacts();
        readonly string _tagContacts = "contact";
        frJobOrders _frJobOrder = new frJobOrders();
        readonly string _tagJobOrder = "joborder";
        frReport _frReport = new frReport();
        readonly string _tagReport = "report";
        frUser _frUser = new frUser();
        readonly string _tagUser = "user";

        frUtilities _frUtilities = new frUtilities();
        readonly string _tagUtilities = "utility";

        void init()
        {
            // init all Modules
            ribbonControlMain.MergeRibbon(_frSchedule.rcSchedule);
            string tag = _tagCompanies;

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
            if(UserManager.ActivatedUser != null)
            {
                rpUser.Text = string.Format("{0}", UserManager.ActivatedUser.UserName.ToUpper());
                if(UserManager.ActivatedUser.RoleName != "ADMIN")
                {
                    rpgEditUser.Visible = false;
                } else
                {
                    rpgEditUser.Visible = true;
                }
            }
            _frUser.SetupUi();

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
                case Keys.F1:
                    changeGroupByCode(_tagUser);
                    break;
                case Keys.F2:
                    changeGroupByCode(_tagCompanies);
                    break;
                case Keys.F3:
                    changeGroupByCode(_tagContacts);
                    break;
                case Keys.F4:
                    changeGroupByCode(_tagJobOrder);
                    break;
                case Keys.F5:
                    changeGroupByCode(_tagCandidates);
                    break;
                case Keys.F6:
                    changeGroupByCode(_tagSchedule);
                    break;
                case Keys.F7:
                    changeGroupByCode(_tagReport);
                    break;
                case Keys.F8:
                    changeGroupByCode(_tagUtilities);
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
            changeGroupByCode(tag);
        }

        private void changeGroupByCode(string tag)
        {
            if (tag == _tagSchedule)
            {
                ribbonControlMain.SelectedPage = _frSchedule.hrpSchedule;
            }
            else
            {
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
            }           
            changeGroup(tag);
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
            if (tag.Equals(_tagCandidates))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(_frCandidate);
                _frCandidate.Dock = DockStyle.Fill;
            }
            if (tag.Equals(_tagSchedule))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(_frSchedule);
                _frSchedule.Dock = DockStyle.Fill;
            }
            if (tag.Equals(_tagCompanies))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(_frCompanies);
                _frCompanies.Dock = DockStyle.Fill;
            }
            if (tag.Equals(_tagContacts))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(_frContacts);
                _frContacts.Dock = DockStyle.Fill;
            }
            if (tag.Equals(_tagJobOrder))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(_frJobOrder);
                _frJobOrder.Dock = DockStyle.Fill;
            }
            if (tag.Equals(_tagReport))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(_frReport);
                _frReport.Dock = DockStyle.Fill;
            }
            if (tag.Equals(_tagUser))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(_frUser);
                _frUser.Dock = DockStyle.Fill;
            }
            if (tag.Equals(_tagUtilities))
            {
                pcMain.Controls.Clear();
                pcMain.Controls.Add(_frUtilities);
                _frUtilities.Dock = DockStyle.Fill;
            }
        }

        private void navBarControl1_CustomDrawLink(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs e)
        {
            if (e.Caption == nbgCandidates.Caption)
                e.Graphics.FillRectangle(Brushes.Red, e.RealBounds);
        }

        private void bbiCandidatesEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frCandidate.editToolStripMenuItem_Click(sender, e);
        }

        private void bbiCandidatesCreate_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frCandidate.newToolStripMenuItem_Click(sender, e);
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frCandidate.deleteToolStripMenuItem_Click(sender, e);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            // add contact
            _frCompanies.newContact();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            // add joborder
            _frCompanies.newJobOrder();
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiUserAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            // add new user
            _frUser.NewUser();
        }

        private void bbiUserEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            // edit current user
            _frUser.EditUser();
        }

        private void bbiUserDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            // delete selected user
            _frUser.DeleteUser();
            
        }

        private void bbiUserHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("This app was writed by PhuongDV for internal process in swifamily's company.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://swilife.com");
        }

        public void showNotice(string message, string caption, MessageBoxIcon icon)
        {

            Image image = null;
            if (icon == MessageBoxIcon.Information)
            {
                image = global::DXSWI.Properties.Resources.Notice_Info_icon;
            } else if(icon == MessageBoxIcon.Warning)
            {
                image = global::DXSWI.Properties.Resources.Button_Warning_icon;
            } else {

                image = global::DXSWI.Properties.Resources.Notice_Support_icon;
            }
            alertControlNotify.Show(this, caption, message, image);
        }

        public void ShowFlyoutMessage(string message)
        {
            lcInfo.Text = message;
            fpNotify.ShowPopup();
        }

        private void bbiAddCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            // add company
            _frCompanies.newCompany();
        }

        private void bbiEditCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frCompanies.editCompany();
        }

        private void bbiDeleteCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frCompanies.deleteCompany();
        }

        private void ribbonControlMain_SelectedPageChanged(object sender, EventArgs e)
        {
            changeGroup(ribbonControlMain.SelectedPage.Tag.ToString());
        }

        private void bbiAddJobOrder0_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frJobOrder.newJobOrder();
        }

        private void bbiEditJobOrder0_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frJobOrder.EditJobOrder();
        }

        private void bbiDeleteJobOrder0_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frJobOrder.deleteJobOrder();
        }

        private void barButtonItem1_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            _frContacts.NewContact();
            
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            _frContacts.EditContact();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frContacts.DeleteContact();
        }

        private void bbiUserChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frUser.changePassword();
        }

        private void bbiEmailSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            // setup mail:
            dlgEmailSetting dlg = new dlgEmailSetting();
            dlg.ShowDialog();
        }

        private void bbiViewCandidateWebsite_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frCandidate.GotoSite();
        }

        private void bbiViewCompanyWebsite_ItemClick(object sender, ItemClickEventArgs e)
        {
            _frCompanies.GotoSite();
        }

        private void ribbonControlMain_Click(object sender, EventArgs e)
        {

        }
    }
}