using Events.BOL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Events.BLL.Interfaces
{
    public interface IEventsServices
    {

        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task<Event> GetEventByIDAsync(int id);
        Task<int> CreateEventAsync(Event Event);
        void UpdateEvent(Event Event);
        void DeleteEvent(int id);
    }
}
