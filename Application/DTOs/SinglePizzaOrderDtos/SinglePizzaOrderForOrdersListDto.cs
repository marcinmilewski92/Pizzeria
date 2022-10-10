using Application.DTOs.AdditionalIngedietDtos;

namespace Application.DTOs.SinglePizzaOrderDtos
{
    public class SinglePizzaOrderForOrdersListDto
    {
        public int SinglePizzaOrderId { get; set; }
        public decimal Price { get; set; }
        public string PizzaName { get; set; } = default!;
        public IEnumerable<AdditionalIngredietDto?> AdditionalIngredients { get; set; }

        public SinglePizzaOrderForOrdersListDto()
        {
            AdditionalIngredients = new List<AdditionalIngredietDto>();
        }
    }
}
