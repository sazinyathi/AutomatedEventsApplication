using Events.BLL.Interfaces;
using Events.BOL;
using Events.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.BLL
{
    public class EventBs : IEventsBs
    {
        IEventDb dbContext;
        public EventBs(IEventDb dbContext)
        {
            this.dbContext = dbContext;
        }
        public int CreateEvent(Event Event)
        {
           return dbContext.CreateEvent(Event);
        }

        public void DeleteEvent(int id)
        {
            dbContext.DeleteEvent(id);
        }

        public IEnumerable<Event> GetAllEvents()
        {
           return dbContext.GetAllEvents();
        }

        public Event GetEventByID(int id)
        {
            return dbContext.GetEventByID(id);
        }

        public void UpdateEvent(Event Event)
        {
            dbContext.UpdateEvent(Event);
        }
    }
}
