using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzeria.Domain.Entities;

namespace Pizzeria.Persistence.Configurations
{
    public class PizzaConfiguration : IEntityTypeConfiguration<Pizza>
    {
       public void Configure(EntityTypeBuilder<Pizza> builder)
        {
            builder.HasData(
                new Pizza()
                {
                    PizzaId = 1,
                    Name = "Margherita",
                    BaseIngredients = new List<BaseIngredient>(),
                    Description = "Classic Italian pizza.",
                    IsAvailable = true,
                    Price = 25.50M
                },
                new Pizza()
                {
                    PizzaId = 2,
                    Name = "Parma",
                    BaseIngredients = new List<BaseIngredient>(),
                    Description = "Delicious pizza with highest queality, fresh ingredients.",
                    IsAvailable = true,
                    Price = 28M
                },
                new Pizza()
                {
                   PizzaId = 3,
                   Name = "Capperi",
                   BaseIngredients = new List<BaseIngredient>(),
                   Description = "Delicious, saulty pizza. Perfect when you are very hungry.",
                    IsAvailable = true,
                   Price = 27.50M
                });



            builder.HasMany(p => p.BaseIngredients)
                   .WithMany(i => i.Pizzas)
                   .UsingEntity<Dictionary<int, int>>(
                   "BaseIngredientPizza",
                   r => r.HasOne<BaseIngredient>().WithMany().HasForeignKey("BaseIngredientId"),
                   l => l.HasOne<Pizza>().WithMany().HasForeignKey("PizzaId"),
                   je =>
                   {
                       je.HasKey("PizzaId", "BaseIngredientId");
                       je.HasData(
                           new { PizzaId = 1, BaseIngredientId = 1 },
                           new { PizzaId = 1, BaseIngredientId = 2 },
                           new { PizzaId = 2, BaseIngredientId = 1 },
                           new { PizzaId = 2, BaseIngredientId = 2 },
                           new { PizzaId = 2, BaseIngredientId = 6 },
                           new { PizzaId = 2, BaseIngredientId = 8 },
                           new { PizzaId = 2, BaseIngredientId = 10 },
                           new { PizzaId = 3, BaseIngredientId = 1 },
                           new { PizzaId = 3, BaseIngredientId = 2 },
                           new { PizzaId = 3, BaseIngredientId = 3 },
                           new { PizzaId = 3, BaseIngredientId = 11 },
                           new { PizzaId = 3, BaseIngredientId = 12 },
                           new { PizzaId = 3, BaseIngredientId = 13 }
                           );
                   });


        }
    }
}
