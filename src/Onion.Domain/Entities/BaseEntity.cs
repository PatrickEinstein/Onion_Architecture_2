using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onion.Domain.Entities
{
    public class BaseEntity
    {
        public DateTimeOffset createdAt { get; set; }
        public DateTimeOffset updateAt { get; set; }
    }
}