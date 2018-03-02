using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsSenderService
{
    class Utilities
    {
        public static void WriteLog(Exception ex)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogSmsSendderService.txt", true);
                sw.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ": " + ex.Source + "; " + ex.Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
                // ignored
            }
        }
        public static void WriteLog(string message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogSmsSendderService.txt", true);
                sw.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ": " + message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
                // ignored
            }
        }
    }
}
