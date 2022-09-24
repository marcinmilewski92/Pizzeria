namespace Pizzeria.Domain.Entities
{
    public class Pizza : IEntity
    {
        public int PizzaId { get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable<BaseIngredient> BaseIngredients { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public bool IsAvailable { get; set; }

        public Pizza()
        {
            BaseIngredients = new List<BaseIngredient>();
        }

    }
}
