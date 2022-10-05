using Application.Features.Users.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Pizzeria.Domain.Identity;
namespace Application.Features.Users.Handlers.Commands
{
    public class RegisterUserRequestHandler : IRequestHandler<RegisterUserRequest, IEnumerable<IdentityError>>
    {
        private readonly IAuthAndUserManager _authManager;
        private readonly IMapper _mapper;

        public RegisterUserRequestHandler(IAuthAndUserManager authManager, IMapper mapper)
        {
            this._authManager = authManager;
            this._mapper = mapper;
        }
        public Task<IEnumerable<IdentityError>> Handle(RegisterUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request.UserDto);
            var response = _authManager.Register(user, request.UserDto.Password);
            return response;
        }
    }
}
