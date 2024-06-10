using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class DbConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public DbConnection()
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["VehicleSalesDBConnectionString"].ConnectionString;
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VehicleSalesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            connection?.Open();
        }

        public void CloseConnection()
        {
            connection?.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }
        public void Commit()
        {
            transaction?.Commit();
        }
        public void Rollback()
        {
            transaction.Rollback();
        }
        public SqlCommand CreateCommand()
        {
            return new SqlCommand("", connection, transaction);
        }
    }
}
