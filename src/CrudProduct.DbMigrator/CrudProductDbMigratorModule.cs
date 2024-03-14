using CrudProduct.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CrudProduct.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CrudProductEntityFrameworkCoreModule),
    typeof(CrudProductApplicationContractsModule)
    )]
public class CrudProductDbMigratorModule : AbpModule
{
}
