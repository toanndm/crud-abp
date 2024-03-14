using Volo.Abp.Modularity;

namespace CrudProduct;

[DependsOn(
    typeof(CrudProductApplicationModule),
    typeof(CrudProductDomainTestModule)
)]
public class CrudProductApplicationTestModule : AbpModule
{

}
