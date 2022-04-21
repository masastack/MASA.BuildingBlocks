namespace Masa.BuildingBlocks.BasicAbility.Pm.Model;

public class ProjectDetailModel : BaseModel
{
    public int Id { get; set; }

    public string Identity { get; set; } = "";

    public int LabelId { get; set; }

    public string Name { get; set; } = "";

    public string Description { get; set; } = "";

    public Guid TeamId { get; set; }

    public List<int> EnvironmentClusterIds { get; set; } = new List<int>();
}
