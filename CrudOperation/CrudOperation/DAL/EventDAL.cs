using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CrudOperation.DAL
{
    public class EventDAL
    {
        DataTable dt = new DataTable();
        public DataTable ReadEventDetails()
        {
            Connection con = new Connection();
            if(ConnectionState.Closed == con.connection.State)
            {
                con.connection.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from EventDetails",con.connection);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch 
            {
                throw;
            }
        }
    }
}
