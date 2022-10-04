using Application.DTOs.UsersDtos;
using MediatR;

namespace Application.Features.Users.Requests.Commands
{
    public class LoginUserRequest : IRequest<AuthResponseDto?>
    {
        public LoginUserDto UserDto { get; set; } = default!;
    }
}
