using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace SWIDAL
{
    public class DataAccess
    {
        private MySqlConnection mCon;
        private static DataAccess instance = null;
        private static readonly object padlock = new object();
        public DataAccess()
        {

        }

        public static DataAccess Instance
        {
            get
            {
                //lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DataAccess();
                    }
                    return instance;
                }

            }
        }

        ~DataAccess()
        {
            mCon?.Close();
        }

        public void ConnectToDB(string connection_string)
        {
            mCon = ConnectToDatabase(connection_string);
            mCon.Open();
        }

        public void closeConnectionToDB()
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
            catch (Exception ex)
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

        public DataSet getDataSet(string query)
        {
            if (mCon == null)
                return null;
            MySqlDataAdapter ad = new MySqlDataAdapter(query, mCon);
            DataSet dt = new DataSet();
            ad.Fill(dt);
            return dt;
        }

        public MySqlDataReader getReader(string query)
        {
            if (mCon == null)
                return null;
            MySqlCommand cmd = new MySqlCommand(query, mCon);
            var result = cmd.ExecuteReader();
            cmd.Dispose();
            return result;
        }

        // function to call store procedure in user table
        public MySqlDataReader getDataByUserName(string userName)
        {
            if (mCon == null) return null;
            MySqlCommand cmd = null;
            try
            {
                cmd = new MySqlCommand("spGetUserByName", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("UserName", userName);
                //cmd.Parameters.Add(userName);
                //cmd.Parameters["UserName"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch
            {
                throw;
            }
            finally
            {
                cmd?.Dispose();

            }
        }

        public bool updateLoginState(string userName, bool value)
        {
            if (mCon == null) return false;
            MySqlCommand cmd = null;
            try
            {
                cmd = new MySqlCommand("spLoginLogout", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("UserName", userName);
                cmd.Parameters.AddWithValue("IsOnline", value);
                //cmd.Parameters.Add(userName);
                //cmd.Parameters.Add(value);
                if (cmd.ExecuteNonQuery() == 0)
                    return false;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd?.Dispose();

            }

        }

        //----------------candiates-------------------
        public DataSet getLimitedCandidates(int offset, int len)
        {
            if (mCon == null) return null;
            MySqlCommand cmd = null;
            DataSet dt = null;
            try
            {
                cmd = new MySqlCommand("spGetCandidates", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd = new MySqlCommand("spGetLimitedCandidates", mCon);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("Offset", offset);
                //cmd.Parameters.AddWithValue("Length", len);

                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = cmd;
                dt = new DataSet();
                ad.Fill(dt, offset, len, "candidate");
            }
            catch
            {
                throw;
            }
            finally
            {
                cmd?.Dispose();

            }
            return dt;
        }

        public int getNumberOfCandidates()
        {
            if (mCon == null) return -1;
            MySqlCommand cmd = null;
            try
            {
                cmd = new MySqlCommand("select count(*) from candidate", mCon);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                throw;
            }
            finally
            {
                cmd?.Dispose();

            }
        }
    }
}
