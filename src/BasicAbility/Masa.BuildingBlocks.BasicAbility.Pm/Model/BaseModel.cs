namespace Masa.BuildingBlocks.BasicAbility.Pm.Model;

public class BaseModel
{
    public Guid Creator { get; set; }

    public DateTime CreationTime { get; set; }

    public Guid Modifier { get; set; }

    public DateTime ModificationTime { get; set; }
}
