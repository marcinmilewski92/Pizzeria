using Application.DTOs.OrdersDtos;
using Application.Features.Orders.Requests.Commands;
using Application.Features.Orders.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pizzeria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> Get(int id)
        {
            return await _mediator.Send(new GetOrderQuery() { Id = id });
        }


        [HttpPost]
        public async Task<ActionResult<int?>> PlaceOrder(PlaceOrderDto placeOrderDto)
        {
            return await _mediator.Send(new PlaceOrderCommand() { PlaceOrderDto = placeOrderDto });
        }

    }
}
