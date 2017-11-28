using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DXSWI.Forms;
using DXSWI.Controls;
using DXSWI.Modules;
using System.Windows.Forms;

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
            //Application.Run(mdlgLogin);
            Application.Run(mMain);
            //showLoginScreen();
        }
        public void showLoginScreen()
        {
            mdlgLogin?.Show();
            mMain?.Hide();
        }
        public void showMainScreen()
        {
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
