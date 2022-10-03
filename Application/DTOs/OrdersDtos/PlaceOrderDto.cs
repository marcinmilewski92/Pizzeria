using Application.DTOs.AddressDtos;

namespace Application.DTOs.OrdersDtos
{
    public class PlaceOrderDto
    {
        public AddressDto DeliveryAddress { get; set; } = default!;
        public List<int> SinglePizzaOrdersIds { get; set; }
        public DateTime DateCreated { get; set; }

        public PlaceOrderDto()
        {
            SinglePizzaOrdersIds = new List<int>();
            DateCreated = DateTime.Now;
        }
    }
}
