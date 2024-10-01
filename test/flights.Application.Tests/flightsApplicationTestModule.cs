using Volo.Abp.Modularity;

namespace flights;

[DependsOn(
    typeof(flightsApplicationModule),
    typeof(flightsDomainTestModule)
)]
public class flightsApplicationTestModule : AbpModule
{

}
