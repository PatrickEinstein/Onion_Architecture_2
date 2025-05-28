using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Onion.Infrastrucure.Configurations
{
    public class OnionDbContext:DbContext
    {
        public OnionDbContext(DbContextOptions<OnionDbContext> options): base(options)
        {
            
        }
    }
}