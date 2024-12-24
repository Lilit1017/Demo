using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace YourNamespace
{
    public class DatabaseConnection
    {
        private NpgsqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DatabaseConnection()
        {
            server = "localhost";
            database = "task_management";
            uid = "postgres";
            password = "1234";
            string connectionString = $"Host={server};Username={uid};Password={password};Database={database}";

            connection = new NpgsqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (NpgsqlException ex)
            {
                throw;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (NpgsqlException ex)
            {
                throw;
            }
        }

        public NpgsqlConnection GetConnection()
        {
            return connection;
        }
    }
}
