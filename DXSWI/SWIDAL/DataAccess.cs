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
        private static MySqlTransaction mTran = null;
        private static string mConnectionString = string.Empty;
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
        //------------------------------- nomal command-------------------
        public void ConnectToDB(string connection_string)
        {
            mConnectionString = connection_string;
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

        private void retryConnectToDb()
        {
            if(mConnectionString.Length > 0)
            {
                mCon = ConnectToDatabase(mConnectionString);
                mCon.Open();
            }
        }

        public object executeScalar(string query)
        {
            if (mCon == null) retryConnectToDb();
            MySqlCommand cmd = new MySqlCommand(query, mCon);
            object result = cmd.ExecuteScalar();
            cmd.Dispose();
            return result;
        }
        public int executeNonQuery(string query)
        {
            if (mCon == null)
                retryConnectToDb();
            MySqlCommand cmd = new MySqlCommand(query, mCon);
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return result;
        }

        public long executeInsertingQuery(string query)
        {
            if (mCon == null)
                retryConnectToDb();
            MySqlCommand cmd = new MySqlCommand(query, mCon);
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            if (result == 0) return -1;
            return cmd.LastInsertedId;
        }

        //public bool executeNonQueryTransaction(string[] queries)
        //{
        //    if (mCon == null)
        //        return false;
        //    MySqlTransaction transaction = mCon.BeginTransaction();
        //    try
        //    {
        //        foreach (var query in queries)
        //        {
        //            MySqlCommand cmd = new MySqlCommand(query, mCon);
        //            cmd.Transaction = transaction;
        //            cmd.ExecuteNonQuery();
        //            cmd.Dispose();
        //        }
        //        transaction.Commit();
        //    }
        //    catch
        //    {
        //        //Console.WriteLine(ex.Message);
        //        transaction.Rollback();
        //        throw;
        //    }
        //    return true;
        //}

        public void StartTransaction()
        {
            if (mCon == null) retryConnectToDb();
            mTran =  mCon.BeginTransaction();
        }

        public bool executeNonQueryTransaction(string querry)
        {
            if(mCon == null) retryConnectToDb();
            MySqlCommand cmd = null;
            try {
                cmd = new MySqlCommand(querry, mCon);
                cmd.Transaction = mTran;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                cmd?.Dispose();
            }
            return true;
        }
        public long executeInsertQueryTransaction(string querry)
        {
            if(mCon == null) retryConnectToDb();
            MySqlCommand cmd = null;
            try
            {
                cmd = new MySqlCommand(querry, mCon);
                cmd.Transaction = mTran;
                cmd.ExecuteNonQuery();
                return cmd.LastInsertedId;
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

        public void commitTransaction()
        {
            if (mCon == null)
                retryConnectToDb();
            mTran?.Commit();
        }

        public void rollbackTransaction()
        {
            if (mCon == null)
                retryConnectToDb();
            mTran?.Rollback();
        }

        public DataTable getDataTable(string query)
        {
            if (mCon == null)
                retryConnectToDb();
            MySqlDataAdapter ad = new MySqlDataAdapter(query, mCon);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public DataSet getDataSet(string query)
        {
            if (mCon == null)
                retryConnectToDb();
            MySqlDataAdapter ad = new MySqlDataAdapter(query, mCon);
            DataSet dt = new DataSet();
            ad.Fill(dt);
            return dt;
        }

        public MySqlDataReader getReader(string query)
        {
            if (mCon == null)
                retryConnectToDb();
            MySqlCommand cmd = new MySqlCommand(query, mCon);
            var result = cmd.ExecuteReader();
            cmd.Dispose();
            return result;
        }

        // function to call store procedure in user table
        public string getUserName(long id)
        {
            if (mCon == null) return string.Empty;
            MySqlCommand cmd = null;
            string userName = string.Empty;
            MySqlDataReader reader = null;
            try
            {

                cmd = new MySqlCommand(string.Format("select user.UserName from user where user.UserId={0}", id), mCon);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userName = reader[0].ToString();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                cmd?.Dispose();
                reader?.Dispose();
            }
            return userName;
        }


        public bool updateLoginState(long UserId, bool value)
        {
            if (mCon == null) return false;
            MySqlCommand cmd = null;
            try
            {
                cmd = new MySqlCommand("spLoginLogout", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("UserId", UserId);
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
        // get data to show on main table
        public DataTable getLimitedCandidates(int offset, int len)
        {
            if (mCon == null) retryConnectToDb();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetLimitedCandidates", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Offset", offset);
                cmd.Parameters.AddWithValue("Length", len);

                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(offset, len, dt);
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

        public DataTable getCandidatesOverview()
        {
            if (mCon == null) retryConnectToDb();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetCandidates", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);
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
            if (mCon == null) retryConnectToDb();
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


        //---------------------------job order----------------------------
        /// <summary>
        /// get and fill data to show on table
        /// </summary>
        /// <returns></returns>
        public DataTable getJobOrders()
        {
            if (mCon == null) retryConnectToDb();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetJobOrders", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);
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

        public DataTable getJobOrdersByCompanyId(long comId)
        {
            if (mCon == null) retryConnectToDb();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetJobOrdersByCompanyId", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ComId", comId);
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);
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

        public DataTable getJobOrderById(long id)
        {
            if (mCon == null) retryConnectToDb();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetJobOrderById", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("JobOrderId", id);
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);
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

        public DataTable getPipelineCandidates(long jobOrderId)
        {
            if (mCon == null) retryConnectToDb();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetCandidatesInPipeline", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("JobOrderId", jobOrderId);
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);

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

        //----------------Company---------------------
        public DataTable getCompaniesOverview()
        {
            if (mCon == null) retryConnectToDb();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetCompanies", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);

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

        //----------------------report-------------------
        public DataTable getReportByTime(DateTime startTime, DateTime endTime)
        {
            if (mCon == null) retryConnectToDb();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetReportByTime", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("StartTime", startTime.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("EndTime", endTime.ToString("yyyy-MM-dd HH:mm:ss"));
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);

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
        public DataTable getReportUserByDate(DateTime startTime, DateTime endTime)
        {
            if (mCon == null) retryConnectToDb();
            MySqlCommand cmd = null
                ;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetReportUserByTime", mCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("StartTime", startTime.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("EndTime", endTime.ToString("yyyy-MM-dd HH:mm:ss"));
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = cmd;
                dt = new DataTable();
                ad.Fill(dt);

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
    }
}
