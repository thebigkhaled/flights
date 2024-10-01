using Microsoft.Extensions.Localization;
using flights.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace flights;

[Dependency(ReplaceServices = true)]
public class flightsBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<flightsResource> _localizer;

    public flightsBrandingProvider(IStringLocalizer<flightsResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
