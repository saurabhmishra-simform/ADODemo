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
    public class DeleteData : IDeleteData
    {
        private int _id { get; set; }
        public void GetDeleteId()
        {
            Console.WriteLine("Employee Id: ");
            _id = Convert.ToInt32(Console.ReadLine());
        }
        public void DeleteRecord()
        {
            DatabaseConnection.ConnectionOpen();
            string deleteQuery = "delete Employee where id = '" + _id + "'";
            try
            {
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, DatabaseConnection.sqlConnection);
                int res = deleteCommand.ExecuteNonQuery();
                if (res == 1)
                {
                    Console.WriteLine("Record deleted!");
                }
                else
                {
                    Console.WriteLine("Record not deleted!");
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
