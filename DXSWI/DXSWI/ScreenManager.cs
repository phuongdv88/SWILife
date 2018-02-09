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
    class ScreenManager
    {
        // this class initializes and manages all of screens, screen modules, user control, form
        static ScreenManager instance = null;
        dlgLogin mdlgLogin;
        SWIMain mMain;
        public static dlgMailEdit EmailEdit = new dlgMailEdit();
        
        ScreenManager()
        {
            //SplashScreenManager.ShowForm(null, typeof(ssMain), true, true, false, 1000);
            mdlgLogin = new dlgLogin();
            mMain = new SWIMain();
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
            //todo: update data
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


    }

}
