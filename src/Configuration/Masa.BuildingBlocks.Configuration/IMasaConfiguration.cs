namespace Masa.BuildingBlocks.Configuration;
public interface IMasaConfiguration
{
    IConfiguration GetConfiguration(SectionTypes sectionType);
}
