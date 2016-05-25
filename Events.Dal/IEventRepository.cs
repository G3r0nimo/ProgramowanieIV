using Events.Dal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Dal
{
    public interface IEventRepository
    {
        void Add(Event e);
        void Update(Event e);
        void Delete(int id);
        Event GetById(int id);
        IQueryable<Event> GetAll();
    }
}
