using System.ComponentModel;

namespace Masa.BuildingBlocks.BasicAbility.Pm.Enum;

public enum AppTypes
{
    [Description("Service")]
    Service = 1,

    [Description("UI")]
    UI,

    [Description("Job")]
    Job
}
