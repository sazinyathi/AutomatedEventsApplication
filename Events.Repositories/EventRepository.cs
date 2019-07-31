using Events.DAL.Interfaces;
using Events.Models;
using Events.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Repositories
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

        public async Task<Event> GetEventByIDAsync(int id)
        {
            return dbContext.Events.Where(x => x.Id == id).FirstOrDefault();
        }


        //public async Task<IEnumerable<Event>> GetAllEventsAsync()
        //{ 
        //    return  dbContext.Events.ToList();
        //}

        public async Task UpdateEventAsync(Event Event)
        {
            dbContext.Update(Event);
            dbContext.SaveChanges();
        }

        public async Task DeleteEventAsync(int id)
        {
            var events = await dbContext.Events.FindAsync(id);
            dbContext.Remove(events);
        }

        public Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
