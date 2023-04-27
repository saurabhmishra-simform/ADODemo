using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoDemo.Interfaces;

namespace AdoDemo.ConnectionString
{
    public static class DatabaseConnection 
    {
        public static SqlConnection sqlConnection;
        static DatabaseConnection()
        {
            sqlConnection = new SqlConnection(@"Data Source=SF-CPU-536\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True");
        }
        public static void ConnectionOpen()
        {
            sqlConnection.Open();
        }

        public static void ConnectionClose()
        {
            sqlConnection.Close();
        }
    }
}
