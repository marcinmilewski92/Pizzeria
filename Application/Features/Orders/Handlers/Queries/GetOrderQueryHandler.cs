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
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, OrderDto?>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetOrderQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            this._orderRepository = orderRepository;
            this._mapper = mapper;
        }
        public async Task<OrderDto?> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetOrderByIdWithDetail(request.Id);

            if (order == null && order.UserId != request.UserName)
            {
                return null;
            }

            var orderDto = _mapper.Map<OrderDto>(order);

            return orderDto;
        }
    }
}
