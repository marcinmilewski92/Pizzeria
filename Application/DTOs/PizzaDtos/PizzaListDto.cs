using Application.DTOs.BaseIngredientDtos;
using Pizzeria.Domain.Entities;

namespace Application.DTOs.PizzaDtos
{
    public class PizzaListDto
    {
        public int PizzaId { get; set; }
        public string Name { get; set; } = string.Empty;
        public IEnumerable<BaseIngredientDto> BaseIngredients { get; set; }
        public decimal Price { get; set; }

        public PizzaListDto()
        {
            BaseIngredients = new List<BaseIngredientDto>();
        }
    }
}
