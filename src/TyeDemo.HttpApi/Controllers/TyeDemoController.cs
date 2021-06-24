using TyeDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TyeDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TyeDemoController : AbpController
    {
        protected TyeDemoController()
        {
            LocalizationResource = typeof(TyeDemoResource);
        }
    }
}