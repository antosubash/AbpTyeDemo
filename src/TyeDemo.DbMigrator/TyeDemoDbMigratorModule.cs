using TyeDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TyeDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TyeDemoEntityFrameworkCoreDbMigrationsModule),
        typeof(TyeDemoApplicationContractsModule)
        )]
    public class TyeDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
