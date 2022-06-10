using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplier.DataModel
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LS461TD\\SQLEXPRESS; " +
                "Database=Entprog_Supplier; Integrated Security=SSPI; " +
                "TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<supplier>().Property(p => p.CompanyName).HasColumnType("nvarchar(100)");
            modelBuilder.Entity<supplier>().Property(p => p.Address).HasColumnType("nvarchar(200)");
            modelBuilder.Entity<supplier>().Property(p => p.Representative).HasColumnType("nvarchar(100)");
            modelBuilder.Entity<supplier>().Property(p => p.ContactNo).HasColumnType("nvarchar(50)");
            modelBuilder.Entity<supplier>().Property(p => p.DateAdded).HasColumnType("datetime");
            modelBuilder.Entity<supplier>().Property(p => p.DateModified).HasColumnType("datetime");
        }

        public DbSet<supplier> SuppliersINV { get; set; }
    }
}
