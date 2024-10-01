using System.Threading.Tasks;

namespace flights.Data;

public interface IflightsDbSchemaMigrator
{
    Task MigrateAsync();
}
