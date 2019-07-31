using Events.API.ViewModels;
using Events.Models;

namespace Events.API.Common.Interface
{
    public interface IHelper
    {
        Event ExtractEvent(EventRecipientViewModel eventRecipientViewModel);
        ReciepentsUsers ExtractReciepentsUsers(EventRecipientViewModel eventRecipientViewModel);
    }
}
