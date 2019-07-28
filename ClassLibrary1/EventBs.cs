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
        public void CreateEvent(Event Event)
        {
            dbContext.CreateEvent(Event);
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
