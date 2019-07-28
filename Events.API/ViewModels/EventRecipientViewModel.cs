using Events.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.API.ViewModels
{
    public class EventRecipientViewModel
    {
        public Event Event { get; set; }
        public ReciepentsUsers ReciepentsUsers { get; set; }
    }
}
