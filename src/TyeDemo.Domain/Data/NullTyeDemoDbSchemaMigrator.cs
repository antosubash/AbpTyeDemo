using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TyeDemo.Data
{
    /* This is used if database provider does't define
     * ITyeDemoDbSchemaMigrator implementation.
     */
    public class NullTyeDemoDbSchemaMigrator : ITyeDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}