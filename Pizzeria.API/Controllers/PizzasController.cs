using Application.DTOs.PizzaDtos;
using Application.Features.Pizzas.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Pizzeria.API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PizzasController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        public async Task<ActionResult<List<PizzaListDto>>> GetPizzas()
        {
            var pizzas = await _mediator.Send(new GetPizzaListQuery());
            return Ok(pizzas);
        }


        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public async Task<ActionResult<PizzaDto>> GePizza(int id)
        {

            var pizza = await _mediator.Send(new GetPizzaByIdQuery() { Id = id });
            if(pizza == null)
            {
                return NotFound();
            }
            return Ok(pizza);
        }
    }
}
