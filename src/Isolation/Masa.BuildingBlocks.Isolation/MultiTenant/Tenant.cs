namespace Masa.BuildingBlocks.Isolation.MultiTenant;
public class Tenant
{
    public string Id { get; set; }

    public Tenant(object id) : this(id?.ToString() ?? throw new ArgumentNullException(nameof(id)))
    {
    }

    public Tenant(string id)
    {
        if (string.IsNullOrEmpty(id))
            throw new ArgumentNullException(nameof(id));

        Id = id;
    }
}
