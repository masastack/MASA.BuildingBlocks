namespace MASA.BuildingBlocks.Configuration;
public interface IConfigurationAPIManage
{
    Task UpdateAsync(string environment, string cluster, string appId, string configObject, object value);
}
