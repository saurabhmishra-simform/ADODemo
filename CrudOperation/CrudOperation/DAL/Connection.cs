using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CrudOperation.DAL
{
    public class Connection
    {
        public SqlConnection connection = new SqlConnection("Data Source=SF-CPU-536\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
         
    }
}
