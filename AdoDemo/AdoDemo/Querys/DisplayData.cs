using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoDemo.ConnectionString;
using AdoDemo.Interfaces;

namespace AdoDemo.Querys
{
    public class DisplayData : IDisplayData
    {
        public void DisplayRecord()
        {
            DatabaseConnection.ConnectionOpen();
            string selectQuery = "select * from Employee";
            try
            {
                SqlCommand display = new SqlCommand(selectQuery, DatabaseConnection.sqlConnection);
                SqlDataReader dataReader = display.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine("Name = " + dataReader.GetValue(1).ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            DatabaseConnection.ConnectionClose();
        }
    }
}
