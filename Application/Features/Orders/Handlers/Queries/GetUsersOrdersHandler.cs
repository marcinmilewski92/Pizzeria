using Application.DTOs.OrdersDtos;
using Application.Features.Orders.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Orders.Handlers.Queries
{
    public class GetUsersOrdersHandler : IRequestHandler<GetUsersOrders, List<UsersOrdersDto>>
    {
        private readonly IAuthAndUserManager _authManager;
        private readonly IMapper _mapper;

        public GetUsersOrdersHandler(IAuthAndUserManager authManager, IMapper mapper)
        {
            this._authManager = authManager;
            this._mapper = mapper;
        }
        public async Task<List<UsersOrdersDto>> Handle(GetUsersOrders request, CancellationToken cancellationToken)
        {
            var orders = await _authManager.GetUsersOreders(request.UserName);

            return _mapper.Map<List<UsersOrdersDto>>(orders);
            
        }
    }
}
