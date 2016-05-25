using Events.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IEventRepository eRepo = new MemoryEventRepository();

            eRepo.Add(new Dal.Model.Event
            {
                Id = 1,
                Title = "ITAD",
                Location = "ATH",
                EventType = Dal.Model.eEventType.eConferenece
            });

            eRepo.Add(new Dal.Model.Event
            {
                Id = 2,
                Title = "DWO",
                Location = "ATH",
                EventType = Dal.Model.eEventType.eConferenece
            });

            foreach (var item in eRepo.GetAll())
            {
                System.Console.WriteLine("Id: {0}, Title: {1}, Location: {2}", 
                    item.Id, item.Title, item.Location);
            }

        }
    }
}
