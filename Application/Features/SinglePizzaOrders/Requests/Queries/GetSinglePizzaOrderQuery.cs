using Application.DTOs.SinglePizzaOrderDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.SinglePizzaOrders.Requests.Queries
{
    public class GetSinglePizzaOrderQuery : IRequest<SinglePizzaOrderDto>
    {
        public int SinglePizzaOrderId { get; set; }
    }
}
