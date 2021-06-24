using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace TyeDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(TyeDemoEntityFrameworkCoreModule)
        )]
    public class TyeDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TyeDemoMigrationsDbContext>();
        }
    }
}
