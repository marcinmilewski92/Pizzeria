using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzeria.Domain.Entities;

namespace Pizzeria.Persistence.Configurations
{
    public class AdditionalIngredientsConfiguration : IEntityTypeConfiguration<AdditionalIngredient>
    {
        public void Configure(EntityTypeBuilder<AdditionalIngredient> builder)
        {
            builder.HasData(
                new AdditionalIngredient()
                {
                    AdditionalIngredientId = 1,
                    Name = "Sausage",
                    Price = 3M
                },
                new AdditionalIngredient()
                {
                    AdditionalIngredientId = 2,
                    Name = "Bacon",
                    Price = 4M
                },
                new AdditionalIngredient()
                {
                    AdditionalIngredientId = 3,
                    Name = "Parsley",
                    Price = 2M
                });
        }
    }
}

