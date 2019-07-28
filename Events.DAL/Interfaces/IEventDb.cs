using Events.BOL;
using System.Collections.Generic;


namespace Events.DAL.Interfaces
{
    public interface IEventDb
    {
        IEnumerable<Event> GetAllCategories();
        Event GetEventByID(int id);
        void CreateEvent(Event Event);
        void UpdateEvent(Event Event);
        void DeleteEvent(int id);
    }
}
