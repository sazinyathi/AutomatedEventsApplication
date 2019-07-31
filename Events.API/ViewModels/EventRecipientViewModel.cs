using Events.Models;

namespace Events.API.ViewModels
{
    public class EventRecipientViewModel
    {
        public Event Event { get; set; }
        public ReciepentsUsers ReciepentsUsers { get; set; }
    }
}
