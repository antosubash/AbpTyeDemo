using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TyeDemo.Data;
using Volo.Abp.DependencyInjection;

namespace TyeDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreTyeDemoDbSchemaMigrator
        : ITyeDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreTyeDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the TyeDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<TyeDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}