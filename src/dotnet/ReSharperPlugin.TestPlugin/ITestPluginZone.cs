using JetBrains.Application.BuildScript.Application.Zones;

namespace ReSharperPlugin.TestPlugin
{
    [ZoneDefinition]
    // [ZoneDefinitionConfigurableFeature("Title", "Description", IsInProductSection: false)]
    public interface ITestPluginZone : IZone
    {
    }
}
