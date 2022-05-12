#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreRelatorioFA.Models;

namespace CoreRelatorioFA.Data
{
    public class CoreRelatorioFAContext : DbContext
    {
        public CoreRelatorioFAContext (DbContextOptions<CoreRelatorioFAContext> options)
            : base(options)
        {
        }

        public DbSet<Sprint> Sprint { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<Contract>().ToTable("Contract");
            modelBuilder.Entity<Invoice>().ToTable("Invoice");
            modelBuilder.Entity<Level>().ToTable("Level");
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<Sprint>().ToTable("Sprint");
        }

        public DbSet<CoreRelatorioFA.Models.Role> Role { get; set; }

        public DbSet<CoreRelatorioFA.Models.Level> Level { get; set; }
    }
}
