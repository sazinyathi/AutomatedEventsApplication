using Events.Models.Settings;

namespace Events.Services.Interfaces
{
    public interface ISettingsService
    {
        RestrictedNames GetRestrictedNames();
    }
}
