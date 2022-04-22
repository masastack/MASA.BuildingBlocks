namespace Masa.BuildingBlocks.BasicAbility.Pm.Model;

public class EnvironmentDetailModel : BaseModel
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public string Description { get; set; } = "";

    public string Color { get; set; } = "";

    public List<int> ClusterIds { get; set; } = default!;
}
