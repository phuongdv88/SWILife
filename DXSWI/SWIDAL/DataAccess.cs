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
        private MySqlConnectionPoolFactory _ConnectionPool = null;
        private static DataAccess instance = null;
        private static readonly object padlock = new object();
        private static string connnectionString = string.Empty;
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
            _ConnectionPool = null;
        }
        //------------------------------- nomal command-------------------
        public void ConnectToDB(string connection_string)
        {
            _ConnectionPool = new MySqlConnectionPoolFactory(connection_string);
        }

        public void closeConnectionToDB()
        {
            _ConnectionPool = null;
        }

        public MySqlConnection ConnectToDatabase(string string_connection)
        {
            return new MySqlConnection(string_connection);
        }

        public object executeScalar(string query)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            object result = cmd.ExecuteScalar();
            cmd.Dispose();
            _ConnectionPool.ReturnConnection(conn);
            return result;
        }
        public int executeNonQuery(string query)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            _ConnectionPool.ReturnConnection(conn);
            return result;
        }

        public long executeInsertingQuery(string query)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            _ConnectionPool.ReturnConnection(conn);
            if (result == 0) return -1;
            return cmd.LastInsertedId;
        }

       
        public MySqlTransaction StartTransaction()
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlTransaction trans =  conn.BeginTransaction();
            return trans;
        }

        public bool executeNonQueryTransaction(string querry, MySqlTransaction trans)
        {
            MySqlCommand cmd = null;
            try {
                cmd = new MySqlCommand(querry, trans.Connection);
                cmd.Transaction = trans;
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
        public long executeInsertQueryTransaction(string querry, MySqlTransaction trans)
        {
            MySqlCommand cmd = null;
            try
            {
                cmd = new MySqlCommand(querry, trans.Connection);
                cmd.Transaction = trans;
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

        public void commitTransaction(MySqlTransaction trans)
        {
            trans?.Commit();
        }

        public void rollbackTransaction(MySqlTransaction trans)
        {
            trans?.Rollback();
        }

        public void ReturnConnectionTransaction(MySqlTransaction trans)
        {
            if (trans == null) return;
            _ConnectionPool.ReturnConnection(trans.Connection);
        }

        public DataTable getDataTable(string query)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            _ConnectionPool.ReturnConnection(conn);
            return dt;
        }

        public DataSet getDataSet(string query)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlDataAdapter ad = new MySqlDataAdapter(query, conn);
            DataSet dt = new DataSet();
            ad.Fill(dt);
            _ConnectionPool.ReturnConnection(conn);
            return dt;
        }

        public MySqlDataReader getReader(string query)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            var result = cmd.ExecuteReader();
            cmd.Dispose();
            _ConnectionPool.ReturnConnection(conn);
            return result;
        }

        // function to call store procedure in user table
        public string getUserName(long id)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            string userName = string.Empty;
            MySqlDataReader reader = null;
            try
            {

                cmd = new MySqlCommand(string.Format("select user.UserName from user where user.UserId={0}", id), conn);
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
                _ConnectionPool.ReturnConnection(conn);
            }
            return userName;
        }


        public bool updateLoginState(long UserId, bool value)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            try
            {
                cmd = new MySqlCommand("spLoginLogout", conn);
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
                _ConnectionPool.ReturnConnection(conn);
            }

        }

        //----------------candiates-------------------
        // get data to show on main table
        public DataTable getLimitedCandidates(int offset, int len)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetLimitedCandidates", conn);
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
                _ConnectionPool.ReturnConnection(conn);
            }
            return dt;
        }

        public DataTable getCandidatesOverview()
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetCandidates", conn);
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
                _ConnectionPool.ReturnConnection(conn);
            }
            return dt;
        }

        public DataTable getCandidatesAvailableForJob(long jobId)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetCandidatesAvailableForJobOrder", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("JobOrderId", jobId);
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
                _ConnectionPool.ReturnConnection(conn);
            }
            return dt;
        }

        public int getNumberOfCandidates()
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            try
            {
                cmd = new MySqlCommand("select count(*) from candidate", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch
            {
                throw;
            }
            finally
            {
                cmd?.Dispose();
                _ConnectionPool.ReturnConnection(conn);
            }
        }


        //---------------------------job order----------------------------
        /// <summary>
        /// get and fill data to show on table
        /// </summary>
        /// <returns></returns>
        public DataTable getJobOrders()
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetJobOrders", conn);
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
                _ConnectionPool.ReturnConnection(conn);
            }
            return dt;
        }

        public DataTable getJobOrdersAvailableforCandidate(long CanId)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("SpGetJobOrdersAvailableForCandidate", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CanId", CanId);
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
                _ConnectionPool.ReturnConnection(conn);
            }
            return dt;
        }

        public DataTable getJobOrdersByCompanyId(long comId)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetJobOrdersByCompanyId", conn);
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
                _ConnectionPool.ReturnConnection(conn);
            }
            return dt;
        }

        public DataTable getJobOrderById(long id)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetJobOrderById", conn);
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
                _ConnectionPool.ReturnConnection(conn);
            }
            return dt;
        }

        public DataTable getPipelineCandidates(long jobOrderId)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetCandidatesInPipeline", conn);
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
                _ConnectionPool.ReturnConnection(conn);
            }
            return dt;
        }

        //----------------Company---------------------
        public DataTable getCompaniesOverview()
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetCompanies", conn);
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
                _ConnectionPool.ReturnConnection(conn);
            }
            return dt;
        }

        //----------------------report-------------------
        public DataTable getReportByTime(DateTime startTime, DateTime endTime)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetReportByTime", conn);
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
                _ConnectionPool.ReturnConnection(conn);
            }
            return dt;
        }
        public DataTable getReportUserByDate(DateTime startTime, DateTime endTime)
        {
            MySqlConnection conn = _ConnectionPool.GetConnection();
            MySqlCommand cmd = null;
            DataTable dt = null;
            try
            {
                cmd = new MySqlCommand("spGetReportUserByTime", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("StartTime", startTime.ToString("yyyy-MM-dd") + " 00:00:00");
                cmd.Parameters.AddWithValue("EndTime", endTime.ToString("yyyy-MM-dd") + " 23:59:59");
                //string tmp = startTime.ToString("yyyy-MM-dd HH:mm:ss");
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
                _ConnectionPool.ReturnConnection(conn);
            }
            return dt;
        }
    }
}
