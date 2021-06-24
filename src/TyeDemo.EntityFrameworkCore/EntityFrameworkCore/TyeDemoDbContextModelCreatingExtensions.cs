using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace TyeDemo.EntityFrameworkCore
{
    public static class TyeDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureTyeDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(TyeDemoConsts.DbTablePrefix + "YourEntities", TyeDemoConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}