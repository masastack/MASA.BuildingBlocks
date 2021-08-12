using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASA.BuildingBlocks.ReadWriteSpliting.CQRS.Events
{
    public class Event
    {
        public Guid Id { get; private set; }

        public DateTime CreationTime { get; private set; }
    }
}
