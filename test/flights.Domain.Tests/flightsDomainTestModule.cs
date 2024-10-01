using Volo.Abp.Modularity;

namespace flights;

[DependsOn(
    typeof(flightsDomainModule),
    typeof(flightsTestBaseModule)
)]
public class flightsDomainTestModule : AbpModule
{

}
