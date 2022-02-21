using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AssemblyLine4.Data
{
    public class AssemblyLineDbContext : DbContext
    {
        public AssemblyLineDbContext(DbContextOptions<AssemblyLineDbContext> options): base(options)
        {

        }
        public DbSet<Operation> OPERATION { get; set; }
        public DbSet<Device> DEVICE { get; set; }
    }
}
