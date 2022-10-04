using Application.DTOs.OrdersDtos;
using MediatR;

namespace Application.Features.Orders.Requests.Queries
{
    public class GetUsersOrders : IRequest<List<UsersOrdersDto>>
    {
        public string UserId { get; set; } = string.Empty;
    }
}
