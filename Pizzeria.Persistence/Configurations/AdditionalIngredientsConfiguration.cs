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
                    Name = "Kiełbasa",
                    Price = 7M
                },
                new AdditionalIngredient()
                {
                    AdditionalIngredientId = 2,
                    Name = "Rukola",
                    Price = 4M
                });
        }
    }
}

