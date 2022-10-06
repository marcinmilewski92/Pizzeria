using Application.Features.Orders.Requests.Commands;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using Pizzeria.Domain.Entities;

namespace Application.Features.Orders.Handlers.Commands
{
    public class PlaceOrderCommandHandler : IRequestHandler<PlaceOrderCommand, int?>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ISinglePizzaOrderRepository _singlePizzaOrderRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public PlaceOrderCommandHandler(IOrderRepository orderRepository, ISinglePizzaOrderRepository singlePizzaOrderRepository, IAddressRepository addressRepository, IMapper mapper)
        {
            this._orderRepository = orderRepository;
            this._singlePizzaOrderRepository = singlePizzaOrderRepository;
            this._addressRepository = addressRepository;
            this._mapper = mapper;
        }
        public async Task<int?> Handle(PlaceOrderCommand request, CancellationToken cancellationToken)
        {
            var requestedSiglePizzaOrdersIds = request.PlaceOrderDto.SinglePizzaOrdersIds;

            if (!requestedSiglePizzaOrdersIds.Any())
            {
                return null;
            }

            var singlePizzaOrders = new List<SinglePizzaOrder>();
            var allSinglePizzaOrders = await _singlePizzaOrderRepository.GetAll();


            requestedSiglePizzaOrdersIds.ForEach(i =>
            {
                if(allSinglePizzaOrders != null)
                {
                    var singlePizzaOrder = allSinglePizzaOrders.FirstOrDefault(o => o.SinglePizzaOrderId == i);
                    if(singlePizzaOrder != null)
                    {
                        singlePizzaOrders.Add(singlePizzaOrder);
                    }
                    
                }
                


            });
            if(requestedSiglePizzaOrdersIds.Count != singlePizzaOrders.Count)
            {
                return null!;
            }

            var address = request.PlaceOrderDto.DeliveryAddress;

            var allAddresses = await _addressRepository.GetAllOrderAddresses();

            var existingAddressId = 0;

            allAddresses.ToList().ForEach(a =>
            {
                if (a.AddressCompare(address))
                {
                    existingAddressId = a.AddressId;
                }

            });


                var order = new Order()
                {
                    SinglePizzaOrders = singlePizzaOrders,
                    DateCreated = request.PlaceOrderDto.DateCreated,
                    UserId= request.UserId
                };

            if(existingAddressId == 0)
            {
                order.DeliveryAddress = _mapper.Map<Address>(request.PlaceOrderDto.DeliveryAddress);
            } else
            {
                order.DeliveryAddress = allAddresses.FirstOrDefault(a => a.AddressId == existingAddressId)!;
            }

                order = await _orderRepository.Add(order);

                return order.OrderId;


            }
        


    }
}
