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
                            Name = "Tomato sauce",
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 2,
                            Name = "Mozzarella",
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 3,
                            Name = "Prosciutto",
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 4,
                            Name = "Mushrooms",
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 5,
                            Name = "Basil",
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 6,
                            Name = "Grana Padano",
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 7,
                            Name = "Jalapeno",
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 8,
                            Name = "Cherry tomatoes",
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 10,
                            Name = "Arugula",
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 11,
                            Name = "Capers"
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 12,
                            Name = "Dried tomatoes"
                        },
                        new BaseIngredient()
                        {
                            BaseIngredientId = 13,
                            Name = "Olives"
                        }
                );
        }
    }
}
