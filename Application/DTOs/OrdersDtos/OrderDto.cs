using Application.DTOs.AddressDtos;
using Application.DTOs.SinglePizzaOrderDtos;

namespace Application.DTOs.OrdersDtos
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public AddressDto DeliveryAddress { get; set; } = default!;
        public decimal FinalPrice => SinglePizzaOrders.Select(o => o.Price).Sum();
        public IEnumerable<SinglePizzaOrderDto> SinglePizzaOrders { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsDelivered { get; set; }

        public OrderDto()
        {
            SinglePizzaOrders = new List<SinglePizzaOrderDto>();
        }
    }
}
