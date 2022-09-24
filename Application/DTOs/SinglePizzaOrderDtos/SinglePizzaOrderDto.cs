using Application.DTOs.AdditionalIngedietDtos;
using Application.DTOs.PizzaDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.SinglePizzaOrderDtos
{
    public class SinglePizzaOrderDto
    {
        public int SinglePizzaOrderId { get; set; }
        public decimal Price { get; set; }
   
        public PizzaListDto Pizza { get; set; } = default!;
        public IEnumerable<AdditionalIngredietDto?> AdditionalIngredients { get; set; }

        public SinglePizzaOrderDto()
        {
            AdditionalIngredients = new List<AdditionalIngredietDto>();
        }
    }
}
