using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masa.BuildingBlocks.BasicAbility.Pm.Model
{
    public enum AppTypes
    {
        [Description("Service")]
        Service = 1,

        [Description("UI")]
        UI,

        [Description("Job")]
        Job
    }
}
