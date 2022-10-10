using Application.DTOs.SinglePizzaOrder;
using Application.DTOs.SinglePizzaOrderDtos;
using Application.Features.SinglePizzaOrders.Requests.Commands;
using Application.Features.SinglePizzaOrders.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Pizzeria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SinglePizzaOrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SinglePizzaOrdersController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public async Task<ActionResult<SinglePizzaOrderDto>> GetSinglePizzaOrder(int id)
        {
            var singlePizzaOrder = await _mediator.Send(new GetSinglePizzaOrderQuery() { SinglePizzaOrderId = id });

            if(singlePizzaOrder == null)
            {
                return NotFound();
            }

            return Ok(singlePizzaOrder);
        }

        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpPost]
        public async Task<ActionResult<int?>> CreateSinglePizzaOrder(SinglePizzaOrderCreateDto singlePizzaOrderCreateDto)
        {
            var singlePizzaOrderId = await _mediator.Send(new CreateSinglePizzaOrderCommand() { SinglePizzaOrderCreateDto = singlePizzaOrderCreateDto});
            if(singlePizzaOrderId == null)
            {
                return BadRequest();
            }
            return Ok(singlePizzaOrderId);
        }
    }
}
