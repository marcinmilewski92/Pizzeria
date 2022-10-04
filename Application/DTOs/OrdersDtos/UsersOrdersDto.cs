using Application.DTOs.AddressDtos;
using Application.DTOs.SinglePizzaOrderDtos;

namespace Application.DTOs.OrdersDtos
{
    public class UsersOrdersDto
    {
        public int OrderId { get; set; }
        public AddressDto DeliveryAddress { get; set; } = default!;
        public decimal FinalPrice => SinglePizzaOrders.Select(o => o.Price).Sum();
        public IEnumerable<SinglePizzaOrderDto> SinglePizzaOrders { get; set; } = new List<SinglePizzaOrderDto>();
        public DateTime DateCreated { get; set; }

    }
}
