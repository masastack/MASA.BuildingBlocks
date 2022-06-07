namespace Masa.BuildingBlocks.Oidc.Storage.Enums;

public enum TokenExpiration
{
    [Description("Sliding token expiration")]
    Sliding,
    [Description("Absolute token expiration")]
    Absolute
}

