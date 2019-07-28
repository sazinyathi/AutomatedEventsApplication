using Events.BOL;
using Events.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.DAL
{
    public class EventDb : IEventDb
    {
        EventsDbContext dbContext;
        public EventDb(EventsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateEvent(Event Event)
        {
            dbContext.Add(Event);
            dbContext.SaveChanges();
        }

        public void DeleteEvent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Event> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Event GetEventByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(Event Event)
        {
            throw new NotImplementedException();
        }
    }
}
