namespace Pizzeria.Domain.Entities
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public Address DeliveryAddress { get; set; } = default!;
        public decimal FinalPrice => SinglePizzaOrders.Select(o => o.Price).Sum();
        public IEnumerable<SinglePizzaOrder> SinglePizzaOrders { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsDelivered { get; set; }
        public string? UserId { get; set; } = string.Empty;

        public Order()
        {
            SinglePizzaOrders = new List<SinglePizzaOrder>();
        }
    }
}
