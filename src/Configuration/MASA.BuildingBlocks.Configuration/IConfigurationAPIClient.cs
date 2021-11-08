namespace MASA.BuildingBlocks.Configuration;
public interface IConfigurationAPIClient
{
    Task<(string Raw, ConfigurationTypes ConfigurationType)> GetRawAsync(string environment, string cluster, string appId, string configObject, Action<string> valueChanged);

    Task<T> GetAsync<T>(string environment, string cluster, string appId, string configObject, Action<T> valueChanged)
        where T : class;

    Task<dynamic> GetDynamicAsync(string environment, string cluster, string appId, string configObject, Action<dynamic> valueChanged);
}

