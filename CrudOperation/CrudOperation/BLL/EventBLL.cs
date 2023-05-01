using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CrudOperation.DAL;
using CrudOperation.DAL.Querys;

namespace CrudOperation.BLL
{
    public class EventBLL
    {
        EventManagement eventManagement = new EventManagement();
        public DataTable GetEventDetails()
        {
            try
            {
                return eventManagement.ReadEventDetails();
            }
            catch
            {
                throw;
            }
        }
        public int InsertData(int EventID,string EventName,decimal EventPrice,string EventDate) 
        {
            try
            {
                return eventManagement.InsertEventDetail(EventID,EventName,EventPrice,EventDate);
            }
            catch
            {
                throw;
            }
        }
        public int UpdateData(int EventID,string EventName)
        {
            try
            {
                return eventManagement.UpdateEventDetail(EventID, EventName);
            }
            catch
            {
                throw;
            }
        }
        public int DeleteData(int EventID)
        {
            try
            {
                return eventManagement.DeleteEventDetail(EventID);
            }
            catch
            {
                throw;
            }
        }
    }
}
