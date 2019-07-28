using Events.BOL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.BLL.Interfaces
{
    interface IEventsBs
    {

        IEnumerable<Event> GetAllCategories();
        Event GetEventByID(int id);
        void CreateEvent(Event Event);
        void UpdateEvent(Event Event);
        void DeleteEvent(int id);
    }
}
