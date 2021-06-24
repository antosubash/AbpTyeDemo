using TyeDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TyeDemo.Web.Pages
{
    public abstract class TyeDemoPageModel : AbpPageModel
    {
        protected TyeDemoPageModel()
        {
            LocalizationResourceType = typeof(TyeDemoResource);
        }
    }
}