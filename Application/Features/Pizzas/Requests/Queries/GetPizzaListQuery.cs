using Application.DTOs.PizzaDtos;
using MediatR;

namespace Application.Features.Pizzas.Requests.Queries
{
    public class GetPizzaListQuery : IRequest<List<PizzaListDto>>
    {
    }
}
