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

        public Order()
        {
            SinglePizzaOrders = new List<SinglePizzaOrder>();
        }
    }
}
