using Volo.Abp.Modularity;

namespace CrudProduct;

public abstract class CrudProductApplicationTestBase<TStartupModule> : CrudProductTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
