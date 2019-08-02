using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Events.API.Common.Interface;
using Events.Models;
using Events.Services.Interfaces;
using Events.API.ViewModels;

namespace Events.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventsServices _eventService;
        public EventsController(IEventsServices eventService)
        {
            _eventService = eventService;
        }

        // GET: api/Events
        [HttpGet]
        public async Task<IActionResult> GetEventsAsync()
        {
            return Ok( await _eventService.GetAllEventsAsync());
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @event =await _eventService.GetEventByIDAsync(id);

            if (@event == null)
            {
                return NotFound();
            }

            return Ok(@event);
        }

        // PUT: api/Events/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent([FromRoute] int id, [FromBody] Event updatedEvent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            updatedEvent.Id = id;
            await _eventService.UpdateEventAsync(updatedEvent);
    
            return Ok();
        }

        // POST: api/Events
        [HttpPost]
        public async Task<IActionResult> PostEvent([FromBody] Event events)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

          var _id =await _eventService.CreateEventAsync(events);
          return CreatedAtAction("GetEvent", new { id = _id }, events);
        }

        // DELETE: api/Events/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var eventToDelete = await _eventService.GetEventByIDAsync(id);
            if (eventToDelete == null)
            {
                return NotFound();
            }

            await _eventService.DeleteEventAsync(id);

            return Ok(eventToDelete);
        }

        
    }
}