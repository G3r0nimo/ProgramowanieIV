using Events.Dal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Dal
{
    public class MemoryEventRepository : IEventRepository
    {
        private List<Event> _events;
        public MemoryEventRepository()
        {
            _events = new List<Event>
            {
                new Event{Id=1, Title="ITAD", Location="ATH", When=DateTime.Now, EventType = eEventType.eConferenece},
                new Event{Id=2, Title="DWO", Location="ATH", When=DateTime.Now, EventType = eEventType.eConferenece},
                new Event{Id=3, Title="Zajecia", Location="A104", When=DateTime.Now, EventType = eEventType.eMeeting},
            };
        }

        public void Add(Model.Event e)
        {
            _events.Add(e);
        }

        public void Update(Model.Event e)
        {
            var eToUpdate = _events.Find(n => n.Id == e.Id);
            eToUpdate.Title = e.Title;
            eToUpdate.Location = e.Location;
            eToUpdate.When = e.When;
            eToUpdate.EventType = e.EventType;
        }

        public void Delete(int id)
        {
            var eToDelete = _events.Find(n => n.Id == id);
            _events.Remove(eToDelete);
        }

        public Model.Event GetById(int id)
        {
            return _events.Find(n => n.Id == id);
        }

        public IQueryable<Model.Event> GetAll()
        {
            return _events.AsQueryable();
        }
    }
}
