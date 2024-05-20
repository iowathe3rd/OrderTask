using Microsoft.EntityFrameworkCore;
using Order.Models.Domain;

namespace Order.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Order.Models.Domain.Order> Orders { get; set; }

     }
}
