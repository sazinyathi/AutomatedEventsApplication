using Events.BOL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.BLL.Interfaces
{
    public interface IEventsBs
    {

        IEnumerable<Event> GetAllEvents();
        Event GetEventByID(int id);
        int CreateEvent(Event Event);
        void UpdateEvent(Event Event);
        void DeleteEvent(int id);
    }
}
