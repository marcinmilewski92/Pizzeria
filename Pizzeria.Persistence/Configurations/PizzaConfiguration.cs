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
                    Name = "Vesuviana",
                    BaseIngredients = new List<BaseIngredient>(),
                    Description = "Przyszna pizza z szynką",
                    IsAvailable = true,
                    Price = 25.50M
                },
                new Pizza()
                {
                    PizzaId = 2,
                    Name = "Capricciosa",
                    BaseIngredients = new List<BaseIngredient>(),
                    Description = "Pyszna pizza z szynką i pieczarkami",
                    IsAvailable = true,
                    Price = 28M
                }
                );
        }
    }
}
