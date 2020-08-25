using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorWaAuHosAgt.Shared;
using BlazorWaAuHosAgt.Shared.Modeltes;
using Microsoft.EntityFrameworkCore;

namespace BlazorWaAuHosAgt.Server.Datates
{
    public class TesDbContext : DbContext
    {
       public TesDbContext()
        {
        }

        public TesDbContext(DbContextOptions<TesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Custalamat> Custalamat { get; set; }
    }
}