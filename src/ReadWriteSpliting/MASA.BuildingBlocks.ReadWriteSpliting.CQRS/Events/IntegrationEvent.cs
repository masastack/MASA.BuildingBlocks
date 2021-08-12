using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Events
{
    public class IntegrationEvent : Event
    {
        public string Topic { get; set; }
    }
}
