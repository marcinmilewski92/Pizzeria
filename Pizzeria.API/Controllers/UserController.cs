using Application.DTOs.UsersDtos;
using Application.Features.Users.Requests.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Pizzeria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpPost]
        [Route("Register")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<IEnumerable<IdentityError>>> RegisterUser(RegisterUserDto userDto)
        {
            var response = await _mediator.Send(new RegisterUserRequest() { UserDto = userDto });

            if (response.Any())
            {
                return BadRequest(response);
            }

            return NoContent();
        }

        [HttpPost]
        [Route("Login")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<AuthResponseDto>> LoginUser(LoginUserDto userDto)
        {
            var response = await _mediator.Send(new LoginUserRequest() { UserDto = userDto });
            if(response == null)
            {
                return Unauthorized();
            }
            return Ok(response);

        }
    }
}
