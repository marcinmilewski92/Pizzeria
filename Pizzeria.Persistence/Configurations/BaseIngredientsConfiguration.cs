using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzeria.Domain.Entities;

namespace Pizzeria.Persistence.Configurations
{
    public class BaseIngredientsConfiguration : IEntityTypeConfiguration<BaseIngredient>
    {
        public void Configure(EntityTypeBuilder<BaseIngredient> builder)
        {
            builder.HasData(
                        new BaseIngredient()
                        {
                            BaseIngredientId = 1,
                            Name = "Sos pomidorowy",
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 2,
                            Name = "Ser",
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 3,
                            Name = "Szynka",
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 4,
                            Name = "Pieczarki",
                        }
                );
        }
    }
}
