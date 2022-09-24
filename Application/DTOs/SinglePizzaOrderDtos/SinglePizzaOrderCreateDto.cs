namespace Application.DTOs.SinglePizzaOrder
{
    public class SinglePizzaOrderCreateDto
    {
        public int PizzaId { get; set; }
        public List<int> AdditionalIngredientsIds { get; set; }

        public SinglePizzaOrderCreateDto()
        {
            AdditionalIngredientsIds = new List<int>();
        }
    }

}
