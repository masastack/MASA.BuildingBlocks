namespace Masa.BuildingBlocks.Oidc.Models.Enums;

public enum TokenExpiration
{
    [Description("Sliding token expiration")]
    Sliding,
    [Description("Absolute token expiration")]
    Absolute
}

