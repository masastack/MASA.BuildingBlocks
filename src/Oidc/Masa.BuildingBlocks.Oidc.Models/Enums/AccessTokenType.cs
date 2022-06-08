namespace Masa.BuildingBlocks.Oidc.Models.Enums;

public enum AccessTokenType
{
    [Description("Self-contained Json Web Token")]
    Jwt,
    [Description("Reference token")]
    Reference
}

