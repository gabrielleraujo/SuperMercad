using Microsoft.EntityFrameworkCore;
using Supermercado.Models;
using Supermercado.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Repository.EntityFrameworkCore
{
    public class SupermercadoDbContext : DbContext
    {
        public DbSet<Mercado> Mercados { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Mercado>()
                .HasKey(t => t.MercadoId);

            modelBuilder
                .Entity<Produto>()
                .HasKey(t => t.ProdutoId);

            modelBuilder
                .Entity<Mercado>()
                .HasMany(m => m.Produtos)
                .WithOne(p => p.Mercado);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SupermercadoDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
    }
}
