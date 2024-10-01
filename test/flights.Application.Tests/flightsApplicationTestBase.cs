using Volo.Abp.Modularity;

namespace flights;

public abstract class flightsApplicationTestBase<TStartupModule> : flightsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
