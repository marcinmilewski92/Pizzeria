namespace Pizzeria.Domain.Entities
{
    public class AdditionalIngredient : IEntity
    {
        public int AdditionalIngredientId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public List<SinglePizzaOrder> SinglePizzaOrders { get; set; }

        public AdditionalIngredient()
        {
            SinglePizzaOrders = new List<SinglePizzaOrder>();
        }

    }
}