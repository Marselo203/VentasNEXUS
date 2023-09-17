using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VentasNEXUS.Models;

namespace VentasNEXUS.Data
{
    public class VentasNEXUSContext : DbContext
    {
        public VentasNEXUSContext (DbContextOptions<VentasNEXUSContext> options)
            : base(options)
        {
        }

        public DbSet<VentasNEXUS.Models.Client> Client { get; set; }

        public DbSet<VentasNEXUS.Models.Products> Products { get; set; }

        public DbSet<VentasNEXUS.Models.Sales> Sales { get; set; }
    }
}
