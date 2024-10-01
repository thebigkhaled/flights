using flights.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace flights.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(flightsEntityFrameworkCoreModule),
    typeof(flightsApplicationContractsModule)
)]
public class flightsDbMigratorModule : AbpModule
{
}
