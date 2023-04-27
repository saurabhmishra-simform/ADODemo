using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoDemo.ConnectionString;
using AdoDemo.Entities;
using AdoDemo.Interfaces;

namespace AdoDemo.Querys
{
    public class InsertData : Employee, IInsertData
    {
        public void InputEmployeeData()
        {
            Console.WriteLine("Employee Id: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Employee Department: ");
            Department = Console.ReadLine();
            Console.WriteLine("Employee Salary: ");
            Salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Employee Gender: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Employee Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee City: ");
            City = Console.ReadLine();
        }
        public void InsertRecord()
        {
            JoinDate = DateTime.Now;

            DatabaseConnection.ConnectionOpen();
            string insertQuery = "insert into Employee values('" + Id + "','" + Name + "','" + Department + "','" + Salary + "','" + Gender + "','" + Age + "','" + City + "','" + string.Format("{0:MM/dd/yyyy}", JoinDate) + "')";
            try
            {
                SqlCommand insertCommand = new SqlCommand(insertQuery, DatabaseConnection.sqlConnection);
                int res = insertCommand.ExecuteNonQuery();
                if (res == 1)
                {
                    Console.WriteLine("Record Inserted Success!");
                }
                else
                {
                    Console.WriteLine("Record not Inserted!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            DatabaseConnection.ConnectionClose();
        }
    }
}
