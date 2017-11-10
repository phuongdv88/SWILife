using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DBTEST.Model
{
    class User : BaseModel
    {
        public int Index { get; set; }
        public string UserName { get; set; }

        public string Password { private get; set; }

        public string md5Password()
        {
            return createMD5Hash(Password + Salt);
        }
        public bool verifyPassword(string password, string salt)
        {
            return verifyMd5Hash(password + salt, Password + Salt);
        }
        public string Salt { get; set; }
        public enum UsserRole{
            ROLE_ROOT = 0,
            ROLE_ADMIN = 1, // ADD, MODIFY, DELETE DB
            ROLE_STAFF = 2, // VIEW ONLY
            ROLE_DEACTIVE = 3,
        }

        public UsserRole Role { get; set; }

        public string PasswordHash { get; set; }

        private string createMD5Hash(string input_string)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash_bytes = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(input_string));
                //convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < hash_bytes.Length; ++i)
                {
                    sb.Append(hash_bytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private bool verifyMd5Hash(string input, string hash)
        {
            string hashOfInput = createMD5Hash(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if(0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            return false;

        }

        public User()
        {

        }
    }
}
