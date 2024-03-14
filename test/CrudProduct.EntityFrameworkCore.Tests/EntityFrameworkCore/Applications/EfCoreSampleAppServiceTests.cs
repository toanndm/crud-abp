using CrudProduct.Samples;
using Xunit;

namespace CrudProduct.EntityFrameworkCore.Applications;

[Collection(CrudProductTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CrudProductEntityFrameworkCoreTestModule>
{

}
