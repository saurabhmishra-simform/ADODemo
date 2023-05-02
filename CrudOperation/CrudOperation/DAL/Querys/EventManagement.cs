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
        public int InsertEventDetail(EventDataHandle eventDataHandle)
        {
            SqlCommand cmd = new SqlCommand("uspInsertEventDetails", Connection.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eventName", eventDataHandle.eventName);
            cmd.Parameters.AddWithValue("@eventPrice", eventDataHandle.eventPrice);
            cmd.Parameters.AddWithValue("@eventDate",dateConvert(eventDataHandle.eventDateTime));
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
        public int UpdateEventDetail(EventDataHandle eventDataHandle)
        {
            SqlCommand cmd = new SqlCommand("uspUpdateEventDetails", Connection.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eventId", eventDataHandle.eventId);
            cmd.Parameters.AddWithValue("@eventName", eventDataHandle.eventName);
            cmd.Parameters.AddWithValue("@eventPrice", eventDataHandle.eventPrice);
            cmd.Parameters.AddWithValue("@eventDate", dateConvert(eventDataHandle.eventDateTime));
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
        public int DeleteEventDetail(EventDataHandle eventDataHandle)
        {
            SqlCommand cmd = new SqlCommand("uspDeleteEventDetails", Connection.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eventId", eventDataHandle.eventId);
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
