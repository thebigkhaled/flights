using Xunit;

namespace flights.EntityFrameworkCore;

[CollectionDefinition(flightsTestConsts.CollectionDefinitionName)]
public class flightsEntityFrameworkCoreCollection : ICollectionFixture<flightsEntityFrameworkCoreFixture>
{

}
