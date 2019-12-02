using Microsoft.EntityFrameworkCore;
using MUGPeru.API.Models;

namespace MUGPeru.API.Data
{
    public partial class NorthwindLiteContext : DbContext
    {
        public NorthwindLiteContext()
        {
        }

        public NorthwindLiteContext(DbContextOptions<NorthwindLiteContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.ApplyAllConfigurations();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
