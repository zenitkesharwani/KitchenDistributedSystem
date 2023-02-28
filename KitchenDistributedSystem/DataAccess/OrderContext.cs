using Microsoft.EntityFrameworkCore;

namespace KitchenDistributedSystem.DataAccess
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> context) : base(context)
        {


        }

        //entities
        public DbSet<Order> Orders { get; set; }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
