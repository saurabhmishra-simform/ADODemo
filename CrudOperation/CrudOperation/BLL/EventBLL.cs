using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CrudOperation.DAL;

namespace CrudOperation.BLL
{
    public class EventBLL
    {
        public DataTable GetEventDetails()
        {
            try
            {
                EventDAL eventDAL = new EventDAL();
                return eventDAL.ReadEventDetails();
            }
            catch
            {
                throw;
            }
        }
    }
}
