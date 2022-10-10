using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Domain.Entities;
using Pizzeria.Domain.Identity;
using Pizzeria.Persistence.Configurations;
using static Pizzeria.Persistence.Configurations.RoleConfiguration;

namespace Pizzeria.Persistence
{
    public class PizzeriaDbContext : IdentityDbContext<User>
    {
        public PizzeriaDbContext(DbContextOptions<PizzeriaDbContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdditionalIngredientsConfiguration());
            modelBuilder.ApplyConfiguration(new BaseIngredientsConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new PizzaConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());




            //   modelBuilder.ApplyConfigurationsFromAssembly(typeof(PizzeriaDbContext).Assembly);
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
