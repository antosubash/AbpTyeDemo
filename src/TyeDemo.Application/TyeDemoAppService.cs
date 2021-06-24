using System;
using System.Collections.Generic;
using System.Text;
using TyeDemo.Localization;
using Volo.Abp.Application.Services;

namespace TyeDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class TyeDemoAppService : ApplicationService
    {
        protected TyeDemoAppService()
        {
            LocalizationResource = typeof(TyeDemoResource);
        }
    }
}
