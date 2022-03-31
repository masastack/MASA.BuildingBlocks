namespace Masa.BuildingBlocks.Isolation;
public interface IIsolation<TKey> : IMultiTenant<TKey>, IMultiEnvironment
    where TKey : IComparable
{
}

public interface IIsolation : IIsolation<Guid>
{
}
