using TyeDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TyeDemo
{
    [DependsOn(
        typeof(TyeDemoEntityFrameworkCoreTestModule)
        )]
    public class TyeDemoDomainTestModule : AbpModule
    {

    }
}