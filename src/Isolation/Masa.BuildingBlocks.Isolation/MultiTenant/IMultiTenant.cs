namespace Masa.BuildingBlocks.Isolation.MultiTenant;
public interface IMultiTenant : IMultiTenant<Guid>
{
}

public interface IMultiTenant<TKey> where TKey : IComparable
{
    /// <summary>
    /// The framework is responsible for the assignment operation, no manual assignment is required
    /// </summary>
    public TKey TenantId { get; set; }
}
