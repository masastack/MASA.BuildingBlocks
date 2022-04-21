namespace Masa.BuildingBlocks.BasicAbility.Pm.Model;

public class EnvironmentClusterModel
{
    public int Id { get; set; }

    public string EnvironmentName { get; set; } = "";

    public string EnvironmentColor { get; set; } = "";

    public string ClusterName { get; set; } = "";

    public string EnvironmentClusterName
    {
        get
        {
            return $"{EnvironmentName}/{ClusterName}";
        }
    }
}
