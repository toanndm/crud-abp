using CrudProduct.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CrudProduct.Permissions;

public class CrudProductPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CrudProductPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CrudProductPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CrudProductResource>(name);
    }
}
