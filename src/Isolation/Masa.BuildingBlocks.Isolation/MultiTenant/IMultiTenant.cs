namespace Masa.BuildingBlocks.Isolation.MultiTenant;
public interface IMultiTenant : IMultiTenant<Guid>
{
}

public interface IMultiTenant<TKey> where TKey : IComparable
{
    public TKey TenantId { get; set; }
}
