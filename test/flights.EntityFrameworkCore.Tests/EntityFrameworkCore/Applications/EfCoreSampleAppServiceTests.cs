using flights.Samples;
using Xunit;

namespace flights.EntityFrameworkCore.Applications;

[Collection(flightsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<flightsEntityFrameworkCoreTestModule>
{

}
