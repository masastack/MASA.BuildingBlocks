namespace Masa.BuildingBlocks.BasicAbility.Pm.Model;

public class ClusterDetailModel : BaseModel
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public string Description { get; set; } = "";

    public List<int> EnvironmentIds { get; set; } = new();
}
