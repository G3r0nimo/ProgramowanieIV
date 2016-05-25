using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.WinForms.ViewModels
{
    public class EventRowViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime When { get; set; }
        public string EventType { get; set; }
    }
}
