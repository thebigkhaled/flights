using flights.Localization;
using Volo.Abp.Application.Services;

namespace flights;

/* Inherit your application services from this class.
 */
public abstract class flightsAppService : ApplicationService
{
    protected flightsAppService()
    {
        LocalizationResource = typeof(flightsResource);
    }
}
