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

                if (AdditionalIngredients != null && AdditionalIngredients.Any())
                {
                    return CurrentPizzaPrice + AdditionalIngredients.Select(i => i.Price).Sum();
                }
                return CurrentPizzaPrice;
            }
        }
        public Pizza Pizza { get; set; } = default!;
        public IEnumerable<AdditionalIngredient> AdditionalIngredients { get; set; }

        public int? OrderId { get; set; }

        public SinglePizzaOrder()
        {
            AdditionalIngredients = new List<AdditionalIngredient>();
        }

    }
}
