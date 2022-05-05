namespace Masa.BuildingBlocks.Oidc.Enum;

public enum AccessTokenType
{
    [Description("Self-contained Json Web Token")]
    Jwt,
    [Description("Reference token")]
    Reference
}

