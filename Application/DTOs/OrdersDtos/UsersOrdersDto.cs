using Application.DTOs.AddressDtos;
using Application.DTOs.SinglePizzaOrderDtos;

namespace Application.DTOs.OrdersDtos
{
    public class UsersOrdersDto
    {
        public int OrderId { get; set; }
        public decimal FinalPrice { get; set; }
        public IEnumerable<SinglePizzaOrderForOrdersListDto> SinglePizzaOrders { get; set; } = new List<SinglePizzaOrderForOrdersListDto>();
        public DateTime DateCreated { get; set; }

    }
}
