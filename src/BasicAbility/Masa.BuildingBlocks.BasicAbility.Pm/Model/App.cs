using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masa.BuildingBlocks.BasicAbility.Pm.Model
{
    public class App
    {
        public int ProjectId { get; set; }

        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Identity { get; set; } = "";

        public string Description { get; set; } = "";

        public int Type { get; set; }

        public int ServiceType { get; set; }
    }
}
