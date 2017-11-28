using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
using System.Reflection;

namespace SWIDAL
{
    public static class QueryBuilder
    {
        public static string mySqlEscape(string str)
        {
            return Regex.Replace(str, @"[\x00'""\b\n\r\t\cZ\\%_]",
                delegate(Match match)
                {
                    string v = match.Value;
                    switch (v)
                    {
                        case "\x00":            // ASCII NUL (0x00) character
                            return "\\0";
                        case "\b":              // BACKSPACE character
                            return "\\b";
                        case "\n":              // NEWLINE (linefeed) character
                            return "\\n";
                        case "\r":              // CARRIAGE RETURN character
                            return "\\r";
                        case "\t":              // TAB
                            return "\\t";
                        case "\u001A":          // Ctrl-Z
                            return "\\Z";
                        default:
                            return "\\" + v;
                    }
                });
        }
        //public static string Create(BaseModel obj)
        //{
        //    string rs = "";
            //if(obj is User)
            //{
            //    var user = obj as User;
            //    rs = string.Format("INSERT INTO `swilifecore`.`user` (`UserName`, `Password`, `Salt`, `Role`) VALUES ('{0}', '{1}', '{2}', '{3}')"
            //        ,mySqlEscape(user.UserName), user.md5Password(), user.Salt,(int) user.Role);

            //}

        //    return rs;
        //}
        //public static string Update(BaseModel obj)
        //{
        //    string rs = "";
            //if (obj is User)
            //{
            //    var user = obj as User;
            //    rs = string.Format("UPDATE `swilifecore`.`user` SET `UserName`= '{0}', `Password`= '{1}', `Salt`= '{2}', `Role`= '{3}' WHERE `UserId`= '{4}'"
            //        , mySqlEscape(user.UserName), user.md5Password(), user.Salt, (int)user.Role, user.Index);

            //}
        //    return rs;
        //}
        //public static string Delete(BaseModel obj)
        //{
        //    string rs = "";
        //    if (obj is User)
        //    {
        //        var user = obj as User;
        //        rs = string.Format("DELETE FROM `swilifecore`.`user` WHERE `UserId`='{0}';", user.Index);
        //    }
        //    return rs;
        //}

        /// <summary>
        /// Converts a DataTable to a list with generic objects
        /// </summary>
        /// <typeparam name="T">Generic object</typeparam>
        /// <param name="table">DataTable</param>
        /// <returns>List with generic objects</returns>
        public static List<T> DataTableToList<T>(this DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();

                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}
