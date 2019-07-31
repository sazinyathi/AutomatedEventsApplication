using Events.BLL.Interfaces;
using Events.BOL;
using Events.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Events.BLL
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
            dbContext.DeleteEvent(id);
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
            dbContext.UpdateEvent(Event);
        }
    }
}
