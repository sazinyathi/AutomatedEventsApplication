using Events.Interfaces.Repositories;
using Events.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly EventsDbContext dbContext;
        public EventRepository(EventsDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public async Task<int> CreateEventAsync(Event newEvent)
        {
            try
            {
                dbContext.Add(newEvent);
                await dbContext.SaveChangesAsync();
                return newEvent.Id;
            }
            catch (System.Exception exc)
            {

                throw;
            }
        }

        public async Task<Event> GetEventByIDAsync(int id)
        {
            return await dbContext.Events.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateEventAsync(Event updatedEvent)
        {
            var eventEntity = await dbContext.Events.FirstOrDefaultAsync(a => a.Id == updatedEvent.Id);
            if (eventEntity == null || eventEntity == default)
            {
                throw new KeyNotFoundException($"Id of '{updatedEvent.Id}' was not found!");
            }
            eventEntity.EventName = updatedEvent.EventName;
            eventEntity.EventLocation = updatedEvent.EventLocation;
            eventEntity.EventDescription = updatedEvent.EventDescription;
            eventEntity.EventCatetogory = updatedEvent.EventCatetogory;
            eventEntity.ActiveRecipients = updatedEvent.ActiveRecipients;
            eventEntity.EventTypeId = updatedEvent.EventTypeId;
            dbContext.Update(eventEntity);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteEventAsync(int id)
        {
            var eventEntity = await dbContext.Events.FirstOrDefaultAsync(a => a.Id == id);
            if(eventEntity == null || eventEntity == default)
            {
                throw new KeyNotFoundException( $"Id of '{id}' was not found!");
            }
            dbContext.Remove(eventEntity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            return await dbContext.Events.AsNoTracking().ToListAsync();
        }
    }
}
