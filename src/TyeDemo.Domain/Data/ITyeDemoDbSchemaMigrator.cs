using System.Threading.Tasks;

namespace TyeDemo.Data
{
    public interface ITyeDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
