﻿using System;
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


        public object executeScalar(string query)
        {
            if (mCon == null)
                return -1;
            MySqlCommand cmd = new MySqlCommand(query, mCon);
            object result = cmd.ExecuteScalar();
            cmd.Dispose();
            return result;
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
            if (mCon == null)
                return;
            mTran =  mCon.BeginTransaction();
        }

        public bool executeNonQueryTransaction(string querry)
        {
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
                return;
            mTran?.Commit();
        }

        public void rollbackTransaction()
        {
            if (mCon == null)
                return;
            mTran?.Rollback();
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

        public string getUserName(int id)
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
        public DataTable getLimitedCandidates(int offset, int len)
        {
            if (mCon == null) return null;
            MySqlCommand cmd = null;
            DataTable dt = null;
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


        //---------------------------job order----------------------------
        public DataTable getJobOrders()
        {
            if (mCon == null) return null;
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
    }
}
