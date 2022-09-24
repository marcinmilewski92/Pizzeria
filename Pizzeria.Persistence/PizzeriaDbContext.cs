using Microsoft.EntityFrameworkCore;
using Pizzeria.Domain.Entities;

namespace Pizzeria.Persistence
{
    public class PizzeriaDbContext : DbContext
    {
        public PizzeriaDbContext(DbContextOptions<PizzeriaDbContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PizzeriaDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<BaseIngredient> BaseIngredients { get; set; }

        public DbSet<SinglePizzaOrder> SinglePizzaOrders { get; set; }
        public DbSet<AdditionalIngredient> AdditionalIngredients { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Addresses { get; set; }


    }
}
