namespace Masa.BuildingBlocks.Oidc.Storage.Enums;

public enum TokenUsage
{
    [Description("Re-use the refresh token handle")]
    ReUse,
    [Description("Issue a new refresh token handle every time")]
    OneTimeOnly
}

