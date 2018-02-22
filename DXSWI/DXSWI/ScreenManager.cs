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
            mdlgLogin = new dlgLogin();
            mMain = new SWIMain();
            EmailEdit = new dlgMailEdit();
            SplashScreenManager.CloseForm();


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
