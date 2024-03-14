using Volo.Abp.Modularity;

namespace CrudProduct;

[DependsOn(
    typeof(CrudProductDomainModule),
    typeof(CrudProductTestBaseModule)
)]
public class CrudProductDomainTestModule : AbpModule
{

}
