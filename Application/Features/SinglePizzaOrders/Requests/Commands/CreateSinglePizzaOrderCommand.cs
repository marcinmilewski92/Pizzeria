using Application.DTOs.SinglePizzaOrder;
using MediatR;

namespace Application.Features.SinglePizzaOrders.Requests.Commands
{
    public class CreateSinglePizzaOrderCommand : IRequest<int?>
    {
        public SinglePizzaOrderCreateDto SinglePizzaOrderCreateDto { get; set; }
    }
}
