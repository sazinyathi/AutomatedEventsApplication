using Events.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.Services.Interfaces
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
