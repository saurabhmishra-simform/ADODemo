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
        public int InsertData(EventDataHandle eventDataHandle) 
        {
            try
            {
                return eventManagement.InsertEventDetail(eventDataHandle);
            }
            catch
            {
                throw;
            }
        }
        public int UpdateData(EventDataHandle eventDataHandle)
        {
            try
            {
                return eventManagement.UpdateEventDetail(eventDataHandle);
            }
            catch
            {
                throw;
            }
        }
        public int DeleteData(EventDataHandle eventDataHandle)
        {
            try
            {
                return eventManagement.DeleteEventDetail(eventDataHandle);
            }
            catch
            {
                throw;
            }
        }
    }
}
