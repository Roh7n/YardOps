using Microsoft.EntityFrameworkCore;
using YardManagement.Core.Entities;

namespace YardManagement.Infrastructure.Data
{
    public class YardDbContext : DbContext
    {
        public YardDbContext(DbContextOptions<YardDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Customer> Customers => Set<Customer>(); 
        public DbSet<Vehicle> Vehicles => Set<Vehicle>();
        public DbSet<Material> Materials => Set<Material>();
        public DbSet<MaterialPriceLog> MaterialPriceLogs => Set<MaterialPriceLog>();
        public DbSet<Sale> Sales => Set<Sale>();
        public DbSet<SaleItem> SaleItems => Set<SaleItem>();
        public DbSet<Payment> Payments => Set<Payment>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Customer)
                .WithMany(c => c.Vehicles)
                .HasForeignKey(v => v.CustomerId);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Customer)
                .WithMany()
                .HasForeignKey(s => s.CustomerId);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Vehicle)
                .WithMany()
                .HasForeignKey(s => s.VehicleId);

            modelBuilder.Entity<SaleItem>()
                .HasOne(si => si.Sale)
                .WithMany(s => s.Items)
                .HasForeignKey(si => si.SaleId);
        }
    }
}
