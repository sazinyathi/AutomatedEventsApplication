using Events.API.ViewModels;
using Events.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.API.Common.Interface
{
    public interface IHelper
    {
        Event ExtractEvent(EventRecipientViewModel eventRecipientViewModel);
        ReciepentsUsers ExtractReciepentsUsers(EventRecipientViewModel eventRecipientViewModel);
    }
}
