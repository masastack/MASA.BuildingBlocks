namespace Masa.BuildingBlocks.Oidc.Abstract;

public abstract class Resource
{
    public bool Enabled { get; set; } = true;

    public string Name { get; set; } = "";

    public string DisplayName { get; set; } = "";

    public string? Description { get; set; }

    public bool ShowInDiscoveryDocument { get; set; } = true;

    [DisallowNull]
    public virtual ICollection<string>? UserClaims { get; set; }

    public IDictionary<string, string>? Properties { get; set; }
}

