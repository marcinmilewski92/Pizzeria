namespace Pizzeria.Domain.Entities
{
    public class BaseIngredient : IEntity
    {
        public int BaseIngredientId { get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable<Pizza> Pizzas { get; set; }

        public BaseIngredient()
        {
            Pizzas = new List<Pizza>();
        }

    }
}