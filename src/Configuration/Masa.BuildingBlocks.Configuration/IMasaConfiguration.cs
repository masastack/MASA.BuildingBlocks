namespace Masa.BuildingBlocks.Configuration;
public interface IMasaConfiguration
{
    IConfiguration GetConfiguration(SectionTypes sectionType);

    /// <summary>
    /// Get the value of the specified key from the DataDictionary of ConfigurationAPI
    /// </summary>
    /// <param name="sectionName">Node name, sectionName is appid if using the capability of Masa.Contrib.BasicAbility.Dcc</param>
    /// <param name="key"></param>
    /// <returns></returns>
    string? GetValueByDataDictionary(string sectionName, string key);
}
