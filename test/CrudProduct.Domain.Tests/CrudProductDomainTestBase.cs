using Volo.Abp.Modularity;

namespace CrudProduct;

/* Inherit from this class for your domain layer tests. */
public abstract class CrudProductDomainTestBase<TStartupModule> : CrudProductTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
