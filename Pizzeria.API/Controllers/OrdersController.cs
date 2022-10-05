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
        private readonly IHttpContextAccessor httpContextAccessor;

        public OrdersController(IMediator mediator, IUserService userService)
        {
            this._mediator = mediator;
            this._userService = userService;
        }

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
