using Events.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.DAL.Interfaces
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task<Event> GetEventByIDAsync(int id);
        Task<int> CreateEventAsync(Event Event);
        Task UpdateEventAsync(Event Event);
        Task DeleteEventAsync(int id);
       
    }
}
