using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace SWIBLL.Models
{
    public class Data
    {
        public static T CreateItemFromRow<T>(DataRow row) where T : new()
        {
            T item = new T();
            SetItemFromRow(item, row);
            return item;
        }

        public static void SetItemFromRow<T>(T item, DataRow row) where T : new()
        {
            //go through each column
            foreach(DataColumn c in row.Table.Columns)
            {
                // find the property fo the column
                PropertyInfo p = item.GetType().GetProperty(c.ColumnName);
                // if exists, set the value

                if (p != null && row[c] != DBNull.Value)
                {
                    if(p.PropertyType.Name == "Int64")
                    {
                        p.SetValue(item, long.Parse(row[c].ToString()), null);
                    } else if(p.PropertyType.Name == "Int32")
                    {
                        p.SetValue(item, int.Parse(row[c].ToString()), null);
                    } else if (p.PropertyType.FullName.StartsWith("System.Nullable`1[[System.Int32"))
                    {
                        p.SetValue(item, (int?)int.Parse(row[c].ToString()), null);
                    }
                    else if (p.PropertyType.FullName.StartsWith("System.Nullable`1[[System.Int64"))
                    {
                        p.SetValue(item, (long?)long.Parse(row[c].ToString()), null);
                    }
                    else if(p.PropertyType.Name == "Boolean")
                    {
                        p.SetValue(item, Convert.ToBoolean(int.Parse(row[c].ToString())), null);
                    }
                    else
                    {
                        p.SetValue(item, row[c], null);
                    }
                }

            }
        }
    }
}
