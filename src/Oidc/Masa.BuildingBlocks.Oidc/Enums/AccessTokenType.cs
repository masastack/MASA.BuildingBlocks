namespace Masa.BuildingBlocks.Oidc.Storage.Enums;

public enum AccessTokenType
{
    [Description("Self-contained Json Web Token")]
    Jwt,
    [Description("Reference token")]
    Reference
}

