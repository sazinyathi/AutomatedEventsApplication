using Events.DAL.Interfaces;
using Events.Models;
using Events.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.Services
{
    public class EventsServices : IEventsServices
    {
        private readonly IEventRepository _eventRepository;
        public EventsServices(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<int> CreateEventAsync(Event newEvent)
        {
           return await _eventRepository.CreateEventAsync(newEvent);
        }

        public async Task DeleteEventAsync(int id)
        {
            await _eventRepository.DeleteEventAsync(id);
        }

        public async Task<IEnumerable<Event>> GetAllEventsAsync()
        {
           return await _eventRepository.GetAllEventsAsync();
        }

        public async Task<Event> GetEventByIDAsync(int id)
        {
            return await _eventRepository.GetEventByIDAsync(id);
        }

        public async Task UpdateEventAsync(Event updatedEvent)
        {
           await _eventRepository.UpdateEventAsync(updatedEvent);
        }
    }
}
