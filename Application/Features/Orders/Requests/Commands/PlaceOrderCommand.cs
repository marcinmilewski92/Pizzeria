using Application.DTOs.Orders;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Orders.Requests.Commands
{
    public class PlaceOrderCommand : IRequest<int?>
    {
        public PlaceOrderDto PlaceOrderDto { get; set; }
    }
}
