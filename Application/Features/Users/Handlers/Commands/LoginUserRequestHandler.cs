using Application.DTOs.UsersDtos;
using Application.Features.Users.Requests.Commands;
using Application.Persistence.Contracts;
using MediatR;

namespace Application.Features.Users.Handlers.Commands
{
    public class LoginUserRequestHandler : IRequestHandler<LoginUserRequest, AuthResponseDto>
    {
        private readonly IAuthManager _authManager;

        public LoginUserRequestHandler(IAuthManager authManager)
        {
            this._authManager = authManager;
        }
        public async Task<AuthResponseDto> Handle(LoginUserRequest request, CancellationToken cancellationToken)
        {
            var response = await _authManager.Login(request.UserDto.Email, request.UserDto.Password);
        if(response != null)
            {
                return new AuthResponseDto()
                {
                    Token = response.GetValueOrDefault("token"),
                    UserId = response.GetValueOrDefault("userId")
                };
            }
        return null;

        }
    }
}
