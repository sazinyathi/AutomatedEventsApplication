using Events.BOL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.DAL.Interfaces
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task<Event> GetEventByIDAsync(int id);
        Task<int> CreateEventAsync(Event Event);
        void UpdateEvent(Event Event);
        void DeleteEvent(int id);
        void JJ();
    }
}
