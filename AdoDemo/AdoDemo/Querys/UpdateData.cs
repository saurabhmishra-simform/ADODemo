using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AdoDemo.ConnectionString;
using AdoDemo.Interfaces;

namespace AdoDemo.Querys
{
    public class UpdateData : IUpdateData
    {
        private int? _id { get; set; }
        private string? _name { get; set; }

        public void GetUpdateData()
        {
            Console.WriteLine("Employee Id: ");
            _id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee Name: ");
            _name = Console.ReadLine();
        }
        public void UpdateRecord()
        {
            DatabaseConnection.ConnectionOpen();
            string updateQuery = "update Employee set Name = '" + _name + "' where Id = '" + _id + "'";
            try
            {
                SqlCommand updateCommand = new SqlCommand(updateQuery, DatabaseConnection.sqlConnection);
                int res = updateCommand.ExecuteNonQuery();
                if (res == 1)
                {
                    Console.WriteLine("Updated Sucessfully!");
                }
                else
                {
                    Console.WriteLine("Record Not Updated!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            DatabaseConnection.ConnectionClose();
        }
    }
}
