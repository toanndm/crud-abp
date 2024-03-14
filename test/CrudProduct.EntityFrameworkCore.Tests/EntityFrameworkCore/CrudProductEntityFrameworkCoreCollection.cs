using Xunit;

namespace CrudProduct.EntityFrameworkCore;

[CollectionDefinition(CrudProductTestConsts.CollectionDefinitionName)]
public class CrudProductEntityFrameworkCoreCollection : ICollectionFixture<CrudProductEntityFrameworkCoreFixture>
{

}
