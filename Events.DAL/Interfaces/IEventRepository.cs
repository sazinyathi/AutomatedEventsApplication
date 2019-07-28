using Events.BOL;
using System.Collections.Generic;


namespace Events.DAL.Interfaces
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetAllEvents();
        Event GetEventByID(int id);
        int CreateEvent(Event Event);
        void UpdateEvent(Event Event);
        void DeleteEvent(int id);
    }
}
