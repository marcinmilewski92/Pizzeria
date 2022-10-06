using Application.DTOs.PizzaDtos;
using MediatR;

namespace Application.Features.Pizzas.Requests.Queries
{
    public class GetPizzaByIdQuery : IRequest<PizzaDto>
    {
        public int Id { get; set; }
    }
}
