using Volo.Abp.Settings;

namespace TyeDemo.Settings
{
    public class TyeDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TyeDemoSettings.MySetting1));
        }
    }
}
