using Events.Dal;
using Events.Dal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.WinForms.ViewModels
{
    public class MianWindowViewModel
    {
        public Dictionary<eEventType, string> EventTypeLabels 
        {
            get
            {
                return new Dictionary<eEventType, string>
                {
                    {eEventType.eConferenece, "Konferencja"},
                    {eEventType.eMeeting, "Spotkanie"},
                };
            }
        }


        public List<EventRowViewModel> Events 
        {
            get
            {
                return _eventsRepository.GetAll().Select(n=>
                    new EventRowViewModel
                    {
                        Id = n.Id,
                        Title = n.Title,
                        Location = n.Location,
                        When = n.When,
                        EventType = EventTypeLabels[n.EventType]
                    }).ToList();
            }
        }

        private IEventRepository _eventsRepository;
        public MianWindowViewModel()
        {
            _eventsRepository = new MemoryEventRepository();
        }
    }
}
