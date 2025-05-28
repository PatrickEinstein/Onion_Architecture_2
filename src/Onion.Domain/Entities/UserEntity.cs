using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Onion.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string userUUID { get; set; } = Guid.NewGuid().ToString();
    }
}