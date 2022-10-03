using Application.DTOs.UsersDtos;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.Users.Requests.Commands
{
    public class RegisterUserRequest : IRequest<IEnumerable<IdentityError>>
    {
        public RegisterUserDto UserDto { get; set; }
    }
}
