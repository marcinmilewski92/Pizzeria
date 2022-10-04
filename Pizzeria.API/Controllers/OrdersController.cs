using Application.DTOs.OrdersDtos;
using Application.Features.Orders.Requests.Commands;
using Application.Features.Orders.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<ActionResult<OrderDto>> GetOrder(int id)
        {
            var userId = User.Claims.ElementAt(3).Value;

            var order = await _mediator.Send(new GetOrderQuery() { Id = id, UserId = userId });

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
            

        }

        [HttpGet()]
        public async Task<ActionResult<List<UsersOrdersDto>>> GetOrdersOfUser()
        {
            var userId = User.Claims.ElementAt(3).Value;

            var orders = await _mediator.Send(new GetUsersOrders()
            {
                UserId = userId
            });
            return Ok(orders);

        }


        [HttpPost]
        public async Task<ActionResult<int?>> PlaceOrder(PlaceOrderDto placeOrderDto)
        {
            if (placeOrderDto == null)
            {
                return BadRequest();
            }
            var userId = User.Claims.ElementAt(3).Value;

            return await _mediator.Send(new PlaceOrderCommand() { PlaceOrderDto = placeOrderDto, UserId = userId });
        }

    }
}
