namespace Masa.BuildingBlocks.BasicAbility.Pm.Model;

public class ClusterModel
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public int EnvironmentClusterId { get; set; }
}
