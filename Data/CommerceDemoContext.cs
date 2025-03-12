using CommerceDemo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommerceDemo.Data
{
    public class CommerceDemoContext : IdentityDbContext<ApplicationUser>
    {
        public CommerceDemoContext (DbContextOptions<CommerceDemoContext> options)
            : base(options)
        {
        }

        public DbSet<CommerceDemo.Models.Product> Product { get; set; } = default!;
        public DbSet<CommerceDemo.Models.ProductCategory> ProductCategory { get; set; } = default!;        
        public DbSet<CommerceDemo.Models.StateLocation> StateLocation { get; set; } = default!;
        public DbSet<CommerceDemo.Models.Order> Order { get; set; } = default!;
        public DbSet<CommerceDemo.Models.OrderProduct> OrderProduct { get; set; } = default!;
        public DbSet<CommerceDemo.Models.OrderStatus> OrderStatus { get; set; } = default!;
        public DbSet<CommerceDemo.Models.OrderHistory> OrderHistory { get; set; } = default!;

        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CommerceDemo.Models.OrderStatus>().ToTable("OrderStatus");
        }
    }
}
