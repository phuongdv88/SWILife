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


        public void initLoginScreen()
        {
            Application.Run(mdlgLogin);
            //Application.Run(mMain);
        }
        public void showLoginScreen()
        {
            mdlgLogin.logout();
            mdlgLogin?.Show();
            mMain?.Hide();
        }
        public void showMainScreen()
        {
            //todo: update data
            // setup ui by role
            mMain?.SetupUiByRole();
            mMain?.Show();
            mdlgLogin?.Hide();

        }

        public void quit()
        {
            mdlgLogin.Close();
            //Application.Exit();
        }

    }

}
