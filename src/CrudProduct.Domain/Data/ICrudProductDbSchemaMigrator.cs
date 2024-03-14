using System.Threading.Tasks;

namespace CrudProduct.Data;

public interface ICrudProductDbSchemaMigrator
{
    Task MigrateAsync();
}
