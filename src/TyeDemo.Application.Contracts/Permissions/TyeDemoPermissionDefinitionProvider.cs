using TyeDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TyeDemo.Permissions
{
    public class TyeDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TyeDemoPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(TyeDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TyeDemoResource>(name);
        }
    }
}
