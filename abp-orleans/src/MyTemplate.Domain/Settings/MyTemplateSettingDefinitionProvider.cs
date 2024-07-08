using Volo.Abp.Settings;

namespace MyTemplate.Settings;

public class MyTemplateSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MyTemplateSettings.MySetting1));
    }
}
