using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Dal.Model
{
    public enum eEventType
    { 
        eConferenece,
        eMeeting,
        eDiscuss
        ///
    }

    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime When { get; set; }
        public eEventType EventType { get; set; }
    }
}
