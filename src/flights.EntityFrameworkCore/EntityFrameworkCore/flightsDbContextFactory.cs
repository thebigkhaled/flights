using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace flights.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class flightsDbContextFactory : IDesignTimeDbContextFactory<flightsDbContext>
{
    public flightsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        flightsEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<flightsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new flightsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../flights.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
