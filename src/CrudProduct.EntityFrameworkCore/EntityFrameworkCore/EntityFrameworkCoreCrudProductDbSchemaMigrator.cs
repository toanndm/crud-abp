using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CrudProduct.Data;
using Volo.Abp.DependencyInjection;

namespace CrudProduct.EntityFrameworkCore;

public class EntityFrameworkCoreCrudProductDbSchemaMigrator
    : ICrudProductDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCrudProductDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the CrudProductDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CrudProductDbContext>()
            .Database
            .MigrateAsync();
    }
}
