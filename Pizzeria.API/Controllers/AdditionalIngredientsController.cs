using Application.DTOs.AdditionalIngedietDtos;
using Application.Features.AdditionalIngredients.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Pizzeria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionalIngredientsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdditionalIngredientsController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<AdditionalIngredietDto>>> GetAdditionalIngredients()
        {
            return await _mediator.Send(new GetAdditionalIngredientsQuery());
        }
    }
}
