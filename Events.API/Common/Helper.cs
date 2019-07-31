using Events.API.Common.Interface;
using Events.API.ViewModels;
using Events.Models;

namespace Events.API.Common
{
    public class Helper : IHelper
    {
        public Event ExtractEvent(EventRecipientViewModel eventRecipientViewModel)
        {
            return new Event
            {
                Id = eventRecipientViewModel.Event.Id,
                EventName = eventRecipientViewModel.Event.EventName,
                EventDescription = eventRecipientViewModel.Event.EventDescription,
                RowCreateDate = eventRecipientViewModel.Event.RowCreateDate,
                EventLocation = eventRecipientViewModel.Event.EventLocation,
                EventTypeId = eventRecipientViewModel.Event.EventTypeId
            };
        }

        public ReciepentsUsers ExtractReciepentsUsers(EventRecipientViewModel eventRecipientViewModel)
        {
            return new ReciepentsUsers
            {
                Id = eventRecipientViewModel.ReciepentsUsers.Id,
                ActiveRecipients = eventRecipientViewModel.ReciepentsUsers.ActiveRecipients,
                NotActiveRecipients = eventRecipientViewModel.ReciepentsUsers.NotActiveRecipients,
                IsEmailSent = false,
                EventId = eventRecipientViewModel.Event.Id
            };
        }
    }
}
