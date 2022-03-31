namespace Masa.BuildingBlocks.Isolation.Environment;
public interface IEnvironment
{
    /// <summary>
    /// The framework is responsible for the assignment operation, no manual assignment is required
    /// </summary>
    public string Environment { get; set; }
}
