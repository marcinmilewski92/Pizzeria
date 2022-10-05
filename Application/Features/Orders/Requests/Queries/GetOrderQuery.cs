using Application.DTOs.OrdersDtos;
using MediatR;

namespace Application.Features.Orders.Requests.Queries
{
    public class GetOrderQuery : IRequest<OrderDto>
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
    }
}
