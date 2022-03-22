namespace Masa.BuildingBlocks.Isolation.MultiTenant;
public interface ITenantContext
{
    Tenant? CurrentTenant { get; }
}
