namespace Masa.BuildingBlocks.Isolation;
public interface IIsolation<TKey> : IMultiTenant<TKey>, IEnvironment
    where TKey : IComparable
{
}

public interface IIsolation : IIsolation<Guid>
{
}
