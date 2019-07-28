﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Events.BOL;
using Events.DAL;
using Events.BLL.Interfaces;
using Events.API.ViewModels;
using Events.API.Common.Interface;

namespace Events.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private IEventsBs eventBs;
        private IRecipientUsers recipientUsers;
        private IHelper helper;

        public EventsController(IEventsBs eventBs, IRecipientUsers recipientUsers, IHelper helper)
        {
            this.eventBs = eventBs;
            this.recipientUsers = recipientUsers;
            this.helper = helper;
        }

        // GET: api/Events
        [HttpGet]
        public IEnumerable<Event> GetEvents()
        {
            return eventBs.GetAllEvents();
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @event = eventBs.GetEventByID(id);

            if (@event == null)
            {
                return NotFound();
            }

            return Ok(@event);
        }

        // PUT: api/Events/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent([FromRoute] int id, [FromBody] Event @event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != @event.Id)
            {
                return BadRequest();
            }
            eventBs.UpdateEvent(@event);
    
            return NoContent();
        }

        // POST: api/Events
        [HttpPost]
        public async Task<IActionResult> PostEvent([FromBody] EventRecipientViewModel eventRecipientViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var events = helper.ExtractEvent(eventRecipientViewModel);
            var repicients = helper.ExtractReciepentsUsers(eventRecipientViewModel);

            eventBs.CreateEvent(events);
            
            recipientUsers.CreateRecipientUsersRepository(repicients);

          return CreatedAtAction("GetEvent", new { id =eventRecipientViewModel.Event.Id }, events);
        }

        // DELETE: api/Events/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @event = eventBs.GetEventByID(id);
            if (@event == null)
            {
                return NotFound();
            }

            eventBs.DeleteEvent(id);

            return Ok(@event);
        }

        
    }
}