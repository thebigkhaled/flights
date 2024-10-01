using Volo.Abp.Settings;

namespace flights.Settings;

public class flightsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(flightsSettings.MySetting1));
    }
}
