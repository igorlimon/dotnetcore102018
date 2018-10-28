using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileHub102018.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgileHub102018
{
    public class AgileHubContext : DbContext
    {
        public AgileHubContext(DbContextOptions<AgileHubContext> options)
            : base(options)
        { }

        public DbSet<DogEntity> Dogs { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
    }
}
