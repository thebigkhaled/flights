using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace flights.Data;

/* This is used if database provider does't define
 * IflightsDbSchemaMigrator implementation.
 */
public class NullflightsDbSchemaMigrator : IflightsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
