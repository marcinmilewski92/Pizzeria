using Application.DTOs.OrdersDtos;
using Application.Features.Orders.Requests.Commands;
using Application.Features.Orders.Requests.Queries;
using Application.Services.Contracts;
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
        private readonly IUserService _userService;

        public OrdersController(IMediator mediator, IUserService userService)
        {
            this._mediator = mediator;
            this._userService = userService;
        }



        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> GetOrder(int id)
        {
            var userName = await _userService.GetUserName(HttpContext);

            var order = await _mediator.Send(new GetOrderQuery() { Id = id, UserName = userName });

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
            

        }


        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ActionResult<List<UsersOrdersDto>>> GetOrdersOfUser()
        {

            var userName = await _userService.GetUserName(HttpContext);

            var orders = await _mediator.Send(new GetUsersOrders()
            {
                UserName = userName
            });
            return Ok(orders);

        }

        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost]
        public async Task<ActionResult<int?>> PlaceOrder(PlaceOrderDto placeOrderDto)
        {
            if (placeOrderDto == null)
            {
                return BadRequest();
            }
            var userId = await _userService.GetUserId(HttpContext);
            var response = await _mediator.Send(new PlaceOrderCommand() { PlaceOrderDto = placeOrderDto, UserId = userId });
            if(response == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }

    }
}
