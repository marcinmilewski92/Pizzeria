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

        [HttpGet]
        public async Task<ActionResult<List<PizzaListDto>>> Get()
        {
            var pizzas = await _mediator.Send(new GetPizzaListQuery());
            return Ok(pizzas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PizzaDto>> Get(int id)
        {
            var pizza = await _mediator.Send(new GetPizzaByIdQuery() { Id = id });
            return Ok(pizza);
        }
    }
}
