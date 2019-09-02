using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Events.Intefarces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Events.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        public NotificationsController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task SendEmail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                BadRequest(ModelState);
            }

            var ff = await _notificationService.SendEmailNotificationForEventAsyc(id);          
        }

    }
}