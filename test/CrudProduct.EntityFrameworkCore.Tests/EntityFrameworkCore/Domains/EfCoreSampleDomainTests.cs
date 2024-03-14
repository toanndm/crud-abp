using CrudProduct.Samples;
using Xunit;

namespace CrudProduct.EntityFrameworkCore.Domains;

[Collection(CrudProductTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CrudProductEntityFrameworkCoreTestModule>
{

}
