using flights.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace flights.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class flightsController : AbpControllerBase
{
    protected flightsController()
    {
        LocalizationResource = typeof(flightsResource);
    }
}
