using MyTemplate.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyTemplate.Permissions;

public class MyTemplatePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MyTemplatePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MyTemplatePermissions.MyPermission1, L("Permission:MyPermission1"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MyTemplateResource>(name);
    }
}
