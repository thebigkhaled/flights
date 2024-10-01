using flights.Samples;
using Xunit;

namespace flights.EntityFrameworkCore.Domains;

[Collection(flightsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<flightsEntityFrameworkCoreTestModule>
{

}
