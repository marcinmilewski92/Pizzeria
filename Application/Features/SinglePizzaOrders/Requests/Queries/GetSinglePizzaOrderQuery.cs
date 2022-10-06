using Application.DTOs.SinglePizzaOrderDtos;
using MediatR;

namespace Application.Features.SinglePizzaOrders.Requests.Queries
{
    public class GetSinglePizzaOrderQuery : IRequest<SinglePizzaOrderDto>
    {
        public int SinglePizzaOrderId { get; set; }
    }
}
