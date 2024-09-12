using Microsoft.EntityFrameworkCore;
using P01_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<Sale> sales { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=P01_SalesDatabase;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(p =>
            {
                p.Property(p => p.Name).HasColumnType("Nvarchar(50)");
                p.Property(p=>p.Quantity).HasColumnType("real");
            });

            modelBuilder.Entity<Customer>(c =>
            {
                c.Property(c=>c.Name).HasMaxLength(100).IsUnicode(true);
                c.Property(c => c.Email).HasMaxLength(80).IsUnicode(false);
            });
            modelBuilder.Entity<Store>().Property(s => s.Name)
                .HasMaxLength(80).IsUnicode(true);
                
        }
    }
}
