using Events.BOL;
using Events.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.DAL
{
    public class EventRepository : IEventRepository
    {
        EventsDbContext dbContext;
        public EventRepository(EventsDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public async Task<int> CreateEventAsync(Event Event)
        {
            dbContext.Add(Event);
            dbContext.SaveChanges();
            return Event.Id;
        }

        public void DeleteEvent(int id)
        {
           var events = dbContext.Events.FindAsync(id);
            dbContext.Remove(events);
        }

        public async Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            return dbContext.Events.ToList();
        }

        public async Task<Event> GetEventByIDAsync(int id)
        {
            return dbContext.Events.Where(x => x.Id == id).FirstOrDefault();
        }

    
        public void UpdateEvent(Event Event)
        {
            dbContext.Update(Event);
            dbContext.SaveChanges();
        }
    }
}
