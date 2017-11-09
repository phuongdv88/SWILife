using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace DBTEST.DatabaseManager
{
    class DataAccess
    {
        private MySqlConnection mCon;
        public DataAccess(string connection_string)
        {
            mCon = ConnectToDatabase(connection_string);
            mCon.Open();
        }

        ~DataAccess()
        {
            mCon?.Close();
        }

        public MySqlConnection ConnectToDatabase(string string_connection)
        {
            return new MySqlConnection(string_connection);
        }

        public int executeNonQuery(string query)
        {
            if (mCon == null)
                return -1;
            MySqlCommand cmd = new MySqlCommand(query, mCon);
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return result;
        }

        public void executeNonQueryTransaction(string[] queries)
        {
            if (mCon == null)
                return;
            MySqlTransaction transaction = mCon.BeginTransaction();
            try
            {
                foreach (var query in queries)
                {
                    MySqlCommand cmd = new MySqlCommand(query, mCon);
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                transaction.Commit();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback();
            }
        }

        public DataTable getTable(string query)
        {
            if (mCon == null)
                return null;
            MySqlDataAdapter ad = new MySqlDataAdapter(query, mCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
