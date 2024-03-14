using Volo.Abp.Settings;

namespace CrudProduct.Settings;

public class CrudProductSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CrudProductSettings.MySetting1));
    }
}
