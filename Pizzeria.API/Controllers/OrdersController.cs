using Application.DTOs.Orders;
using Application.Features.Orders.Requests.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pizzeria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<int?>> PlaceOrder(PlaceOrderDto placeOrderDto)
        {
            return await _mediator.Send(new PlaceOrderCommand() { PlaceOrderDto = placeOrderDto });
        }

    }
}
