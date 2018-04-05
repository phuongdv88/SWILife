using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SWIDAL
{
    class MySqlConnectionPoolFactory
    {
        private ConcurrentBag<MySqlConnection> _ConnectionPool = new ConcurrentBag<MySqlConnection>();
        private string _ConnectionString = string.Empty;
        private int MaxConnections = 10;
        public MySqlConnectionPoolFactory(string connectionString)
        {
            _ConnectionString = connectionString;
            for (int i = 0; i < MaxConnections; i++)
            {
                _ConnectionPool.Add(openConnection());
            }
        }

        ~MySqlConnectionPoolFactory()
        {
            foreach (var con in _ConnectionPool)
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private MySqlConnection openConnection()
        {
            MySqlConnection conn = new MySqlConnection(_ConnectionString);
            conn.Open();
            return conn;
        }

        public void ReturnConnection(MySqlConnection conn)
        {
            // return connection after using
            if (conn == null) return;
            if (_ConnectionPool.Count < MaxConnections)
            {
                _ConnectionPool.Add(conn);
            } else
            {
                conn.Close();
                conn = null;
            }
        }

        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = null;
            while (!_ConnectionPool.IsEmpty)
            {
                if (_ConnectionPool.TryTake(out conn))
                {
                    if (conn.State == ConnectionState.Open) // if conn is open -> return conn
                        return conn;
                    else
                    {
                        // connection is break -> create new connection
                        return openConnection();
                    }
                } else
                {
                    break;
                }
            }
            return openConnection();
        }
    }
}
