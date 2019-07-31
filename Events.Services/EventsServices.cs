using Events.DAL.Interfaces;
using Events.Models;
using Events.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.Services
{
    public class EventsServices : IEventsServices
    {
        IEventRepository dbContext;
        public EventsServices(IEventRepository dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreateEventAsync(Event Event)
        {
           return await dbContext.CreateEventAsync(Event);
        }

        public void DeleteEvent(int id)
        {
            dbContext.DeleteEventAsync(id);
        }

        public async Task<IEnumerable<Event>> GetAllEventsAsync()
        {
           return await dbContext.GetAllEventsAsync();
        }

        public async Task<Event> GetEventByIDAsync(int id)
        {
            return await dbContext.GetEventByIDAsync(id);
        }

        public void UpdateEvent(Event Event)
        {
            dbContext.UpdateEventAsync(Event);
        }
    }
}
