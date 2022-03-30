namespace Masa.BuildingBlocks.Isolation.MultiTenant;
public class Tenant
{
    public string Id { get; set; }

    public Tenant(object id) : this(id.ToString() ?? String.Empty)
    {
    }

    public Tenant(string id) => Id = id;
}
