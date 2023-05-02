using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.DAL.Querys
{
    public class EventDataHandle
    {
        private int _EventId;
        private string _EventName;
        private decimal _EventPrice;
        private string _EventDateTime;
        public int eventId
        {
            get { return _EventId; }
            set { _EventId = value; }
        }
        public string eventName
        {
            get { return _EventName; }
            set { _EventName = value; }
        }
        public decimal eventPrice
        {
            get { return _EventPrice; }
            set { _EventPrice = value; }
        }
        public string eventDateTime
        {
            get { return _EventDateTime; }
            set { _EventDateTime = value; }
        }

    }
}
