using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DXSWI.Forms;
using DXSWI.Controls;
using DXSWI.Modules;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using DevExpress.XtraEditors;

namespace DXSWI
{
    class ScreenManager : IDisposable
    {
        // this class initializes and manages all of screens, screen modules, user control, form
        static ScreenManager instance = null;
        private dlgLogin mdlgLogin;
        private SWIMain mMain;
        public dlgMailEdit EmailEdit { get; set; }
        
        ScreenManager()
        {
            SplashScreenManager.ShowForm(null, typeof(ssMain), false, false, false, 1000);
            //checkUpdateVersion(null, null);
            mdlgLogin = new dlgLogin();
            mMain = new SWIMain();
            EmailEdit = new dlgMailEdit();
            SplashScreenManager.CloseForm();


            // init timer check update version
            Timer aTimer = new Timer();
            aTimer.Tick += checkUpdateVersion;
            aTimer.Interval = 1000 * 60 * 15; // check every 15 minutes 
            aTimer.Enabled = true;

        }
        /// <summary>
        /// if have new version, please update version in Property project and in inno setup compiler script. These versions need to be equal
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void checkUpdateVersion(object source, EventArgs e)
        {
            try {
                var installLink = Properties.Settings.Default.IntallerLink;
                var filename = installLink.Split('\\').Last();
                // check exist this file or not?
                if (File.Exists(installLink))
                {
                    // check version of this file
                    FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(installLink);
                    var productVersion = new Version(myFileVersionInfo.ProductVersion);

                    Assembly assembly = Assembly.GetExecutingAssembly();
                    FileVersionInfo fileVI = FileVersionInfo.GetVersionInfo(assembly.Location);
                    var currentVersion = new Version(fileVI.FileVersion);
                    // if this version > current version show message box
                    if (productVersion.CompareTo(currentVersion) > 0)
                    {
                        // if click yes then download this installer file to temporary folder
                        if (XtraMessageBox.Show("New version of ATS is available. Woud you like to update it now?","System Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            var templink = Path.GetTempPath() + filename;
                            if(File.Exists(templink))
                            {
                                File.Delete(templink);
                            }
                            File.Copy(installLink, templink);
                            // create process
                            Process.Start(templink);
                            // close system
                            Quit();
                            Application.Exit();
                        }
                    }
                }
            }
            catch
            {

            }

        }

        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                }

                return instance;
            }
        }


        public void InitLoginScreen()
        {

            Application.Run(mdlgLogin);

            //Application.Run(mMain);
        }
        public void ShowLoginScreen()
        {
            mdlgLogin.logout();
            mdlgLogin?.Show();
            mMain?.Hide();
            checkUpdateVersion(null, null);
        }
        public void ShowMainScreen()
        {
            // setup ui by role
            mMain?.SetupUiByRole();
            mMain?.InitComponents();
            mMain?.Show();
            mdlgLogin?.Hide();

        }

        public void Quit()
        {
            mdlgLogin.Close();
            //Application.Exit();
        }

        public void ShowNoticeMessage(string message, string caption, MessageBoxIcon icon)
        {
            mMain?.ShowNotice(message, caption, icon);
        }

        public void NewAppointment(string subject = "", string desc = "")
        {
            mMain?.NewAppointment(subject, desc);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

}
