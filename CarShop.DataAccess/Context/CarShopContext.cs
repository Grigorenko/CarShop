using CarShop.Models;
using System.Data.Entity;

namespace CarShop.DataAccess.Context
{
    public class CarShopContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasKey(entity => entity.Id);
            base.OnModelCreating(modelBuilder);
        }
        public CarShopContext() : base("CarShop") { }
    }
}
