using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DXSWI.Forms;
using System.Threading;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace DXSWI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            // check has another instance yet?
            var createdNew = false;
            string appGuid = "84KJF-LKAJF-W4EROIEJRL-ALKFJALSL-IH348ALF";
            using (Mutex mutex = new Mutex(false, appGuid, out createdNew))
            {
                if (!createdNew)
                {
                    XtraMessageBox.Show("Application is already running!", "Multiple Instances", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var sw = Stopwatch.StartNew();
                ScreenManager.Instance.InitLoginScreen();
                sw.Stop();
                MessageBox.Show(string.Format("{0}", sw.ElapsedMilliseconds)) ;
            }
        }
    }
}
