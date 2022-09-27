namespace Pizzeria.Domain.Entities
{
    public class SinglePizzaOrder : IEntity
    {
        public int SinglePizzaOrderId { get; set; }
        public decimal CurrentPizzaPrice { get; set; }
        public decimal Price
        {
            get
            {
                try
                {
                    return CurrentPizzaPrice + AdditionalIngredients.Select(i => i.Price).Sum();

                }
                catch { return CurrentPizzaPrice; }
            }
        }
        public Pizza Pizza { get; set; } = default!;
        public IEnumerable<AdditionalIngredient?> AdditionalIngredients { get; set; }

        public int? OrderId { get; set; }

        public SinglePizzaOrder()
        {
            AdditionalIngredients = new List<AdditionalIngredient>();
        }

    }
}
