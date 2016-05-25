using Events.Dal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.WinForms.ViewModels
{
    public class AddEditViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }        
        public eEventType SelectedEventType { get; set; }
        public Dictionary<eEventType, string> EventTypeLabels { get; set; }
    }
}
