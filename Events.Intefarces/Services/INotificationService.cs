using Events.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Events.Intefarces.Services
{
   public  interface INotificationService
    {
       Task<Event> SendEmailNotificationForEventAsyc(int eventId);
    }
}
