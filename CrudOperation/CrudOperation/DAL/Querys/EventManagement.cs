using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.DAL.Querys
{
    public class EventManagement
    {
        DateConvertDelegate dateConvert = new DateConvertDelegate(DateConvert.DateConvertSQLFormate);
        public int InsertEventDetail(int EventID, string EventName, decimal EventPrice, string EventDate)
        {
            SqlCommand cmd = new SqlCommand("uspInsertEventDetails", Connection.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eventId", EventID);
            cmd.Parameters.AddWithValue("@eventName", EventName);
            cmd.Parameters.AddWithValue("@eventPrice", EventPrice);
            cmd.Parameters.AddWithValue("@eventDate",dateConvert(EventDate));
            try
            {
                Connection.CheckConnectionState();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch
            {
                throw;
            }
        }
        public int UpdateEventDetail(int EventID, string EventName)
        {
            SqlCommand cmd = new SqlCommand("uspUpdateEventDetails", Connection.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eventId", EventID);
            cmd.Parameters.AddWithValue("@eventName", EventName);
            try
            {
                Connection.CheckConnectionState();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch
            {
                throw;
            }
        }
        public int DeleteEventDetail(int EventID)
        {
            SqlCommand cmd = new SqlCommand("uspDeleteEventDetails", Connection.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eventId", EventID);
            try
            {
                Connection.CheckConnectionState();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch
            {
                throw;
            }
        }
        public DataTable ReadEventDetails()
        {
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("uspShowAllEventDetails", Connection.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                Connection.CheckConnectionState();
                SqlDataReader rd = cmd.ExecuteReader();
                dataTable.Load(rd);
                return dataTable;
            }
            catch
            {
                throw;
            }
        }
    }
}
