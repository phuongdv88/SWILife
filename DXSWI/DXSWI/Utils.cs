using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXSWI
{
    public class Utils
    {
        public static string getRandomAlphaNumeric(int len)
        {
            Random rand = new Random();
            string pool = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var chars = Enumerable.Range(0, len).Select(x => pool[rand.Next(0, pool.Length - 1)]);
            return new string(chars.ToArray());
        }
    }
}
