using System;

namespace Kollekt.Core.Domain
{
    public class Operation: Entity
    {
        public string Name { get; set; }
        public Guid WorkplaceId { get; set; }
    }
}