using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class OrderContext : DbContext
    {
        public string connectionString { set; get; }
        public OrderContext() : base()
        {

            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        //entities
        public DbSet<Order> Orders { get; set; }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
