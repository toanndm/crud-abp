using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CrudProduct.Data;

/* This is used if database provider does't define
 * ICrudProductDbSchemaMigrator implementation.
 */
public class NullCrudProductDbSchemaMigrator : ICrudProductDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
