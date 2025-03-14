using CommerceDemo.Data.Models;
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

        public DbSet<CommerceDemo.Data.Models.Product> Product { get; set; } = default!;
        public DbSet<CommerceDemo.Data.Models.ProductCategory> ProductCategory { get; set; } = default!;        
        public DbSet<CommerceDemo.Data.Models.StateLocation> StateLocation { get; set; } = default!;
        public DbSet<CommerceDemo.Data.Models.Order> Order { get; set; } = default!;
        public DbSet<CommerceDemo.Data.Models.OrderProduct> OrderProduct { get; set; } = default!;
        public DbSet<CommerceDemo.Data.Models.OrderStatus> OrderStatus { get; set; } = default!;
        public DbSet<CommerceDemo.Data.Models.OrderHistory> OrderHistory { get; set; } = default!;

        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CommerceDemo.Data.Models.OrderStatus>().ToTable("OrderStatus");
        }
    }
}
