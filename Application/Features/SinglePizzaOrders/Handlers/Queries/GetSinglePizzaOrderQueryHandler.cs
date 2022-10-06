using Application.DTOs.SinglePizzaOrderDtos;
using Application.Features.SinglePizzaOrders.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using Pizzeria.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.SinglePizzaOrders.Handlers.Queries
{
    public class GetSinglePizzaOrderQueryHandler : IRequestHandler<GetSinglePizzaOrderQuery, SinglePizzaOrderDto>
    {
        private readonly ISinglePizzaOrderRepository _singlePizzaOrderRepository;
        private readonly IMapper _mapper;

        public GetSinglePizzaOrderQueryHandler(ISinglePizzaOrderRepository singlePizzaOrderRepository,
            IMapper mapper)
        {
            this._singlePizzaOrderRepository = singlePizzaOrderRepository;
            this._mapper = mapper;
        }
        public async Task<SinglePizzaOrderDto> Handle(GetSinglePizzaOrderQuery request, CancellationToken cancellationToken)
        {
            var singlePizzaOrder = await _singlePizzaOrderRepository.GetSinglePizzaOrderWithDetails(request.SinglePizzaOrderId);

            var singlePizzaOrderDto = _mapper.Map<SinglePizzaOrderDto>(singlePizzaOrder);

            return singlePizzaOrderDto;
        }
    }
}
