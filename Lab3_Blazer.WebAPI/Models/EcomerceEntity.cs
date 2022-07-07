using Lab3_Blazer.shared;
using Microsoft.EntityFrameworkCore;

namespace Lab3_Blazer.WebAPI.Models
{
    public class EcomerceEntity : DbContext
    {
        public EcomerceEntity()
        {

        }
        public EcomerceEntity(DbContextOptions option) : base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<OrderProduct>()
                .HasKey(or => new { or.OrderId, or.ProductId });
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
    }
}

