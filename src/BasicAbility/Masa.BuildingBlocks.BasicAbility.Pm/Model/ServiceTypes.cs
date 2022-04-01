using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masa.BuildingBlocks.BasicAbility.Pm.Model
{
    public enum ServiceTypes
    {
        [Description("Dapr")]
        Dapr = 1,

        [Description("WebApi")]
        WebApi
    }
}
