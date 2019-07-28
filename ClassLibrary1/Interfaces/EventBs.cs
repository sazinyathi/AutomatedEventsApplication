using System;
using System.Collections.Generic;
using System.Text;
using Events.BOL;
using Events.DAL;
using Events.DAL.Interfaces;

namespace Events.BLL.Interfaces
{
    public class EventBs : IEventsBs
    {
        private IEventDb eventDb;
        public EventBs(IEventDb eventDb)
        {
            this.eventDb = eventDb;
        }
        public int CreateEvent(Event Event)
        {
            return eventDb.CreateEvent(Event);
        }

        public void DeleteEvent(int id)
        {
            eventDb.DeleteEvent(id);
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return eventDb.GetAllEvents();
        }

        public Event GetEventByID(int id)
        {
            return eventDb.GetEventByID(id);
        }

        public void UpdateEvent(Event Event)
        {
            eventDb.UpdateEvent(Event);
        }
    }
}
