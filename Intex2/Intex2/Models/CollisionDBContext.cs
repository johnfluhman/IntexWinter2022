using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2.Models
{
    public class CollisionDBContext : DbContext
    {
        public CollisionDBContext(DbContextOptions<CollisionDBContext> options) : base(options)
        {
        }
        public DbSet<Collision> Collisions { get; set; }
    }
}









