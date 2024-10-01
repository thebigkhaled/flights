using Volo.Abp.Modularity;

namespace flights;

/* Inherit from this class for your domain layer tests. */
public abstract class flightsDomainTestBase<TStartupModule> : flightsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
