using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masa.BuildingBlocks.BasicAbility.Pm.Model
{
    public class ProjectApps : Project
    {
        public List<App> Apps { get; set; } = new();
    }
}
