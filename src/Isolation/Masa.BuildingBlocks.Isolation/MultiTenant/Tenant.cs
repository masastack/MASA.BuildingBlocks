namespace Masa.BuildingBlocks.Isolation.MultiTenant;
public class Tenant
{
    public string Id { get; set; }

    public Tenant() { }

    public Tenant(string id) : this() => Id = id;
}
