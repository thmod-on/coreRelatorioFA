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

        public DbSet<Invoicing> Invoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<Contract>().ToTable("Contract");
            modelBuilder.Entity<Invoicing>().ToTable("Invoicing");
        }
    }
}
