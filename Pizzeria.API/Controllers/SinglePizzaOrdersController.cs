using Application.DTOs.SinglePizzaOrder;
using Application.DTOs.SinglePizzaOrderDtos;
using Application.Features.SinglePizzaOrders.Requests.Commands;
using Application.Features.SinglePizzaOrders.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Pizzeria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinglePizzaOrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SinglePizzaOrdersController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SinglePizzaOrderDto>> Get(int id)
        {
            var singlePizzaOrder = await _mediator.Send(new GetSinglePizzaOrderQuery() { SinglePizzaOrderId = id });

            if(singlePizzaOrder == null)
            {
                return NotFound();
            }

            return Ok(singlePizzaOrder);
        }

        [HttpPost]
        public async Task<ActionResult<int?>> Create(SinglePizzaOrderCreateDto singlePizzaOrderCreateDto)
        {
            var singlePizzaOrderId = await _mediator.Send(new CreateSinglePizzaOrderCommand() { SinglePizzaOrderCreateDto = singlePizzaOrderCreateDto});
            if(singlePizzaOrderId == null)
            {
                return BadRequest("Selected Pizza does not exist");
            }
            return Ok(singlePizzaOrderId);
        }
    }
}
