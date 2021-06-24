using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TyeDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class TyeDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "TyeDemo";
    }
}
