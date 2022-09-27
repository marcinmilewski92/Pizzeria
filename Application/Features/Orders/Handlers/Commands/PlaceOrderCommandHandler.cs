using Application.DTOs.Orders;
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

            if(!request.PlaceOrderDto.SinglePizzaOrdersIds.Any())
            {
                return null;
            }

            var singlePizzaOrders = new List<SinglePizzaOrder>();
            var allSinglePizzaOrders = await _singlePizzaOrderRepository.GetAll();


            request.PlaceOrderDto.SinglePizzaOrdersIds?.ForEach(i =>
            {
                
                    singlePizzaOrders.Add(allSinglePizzaOrders.FirstOrDefault(o => o.SinglePizzaOrderId == i));
                    
                
            });

            var address = request.PlaceOrderDto.DeliveryAddress;

            Order order;
            
            //if addresses are "equal" including id use existing database address record
            if (address != null && address.AddressId != null && address.AddressId != 0)
            {
                var existingAddress = await _addressRepository.Get(address.AddressId.Value);
                if (existingAddress.AddressCompare(address))
                {
                    order = new Order() { DeliveryAddress = existingAddress, SinglePizzaOrders = singlePizzaOrders };

                    order = await _orderRepository.Add(order);
                }
                else
                {
                    order = new Order() { DeliveryAddress = _mapper.Map<Address>(request.PlaceOrderDto.DeliveryAddress) };
                    order.DeliveryAddress.AddressId = 0;

                    order = await _orderRepository.Add(order);
                }
            }
            else
            {
                order = new Order() { DeliveryAddress = _mapper.Map<Address>(request.PlaceOrderDto.DeliveryAddress) };
                order.DeliveryAddress.AddressId = 0;

                order = await _orderRepository.Add(order);
            }


            //if addresses are not "equal" including id => creating new database address record



            request.PlaceOrderDto.SinglePizzaOrdersIds?.ForEach(i =>
            {
               
                var sPOO = allSinglePizzaOrders.FirstOrDefault(o => o.SinglePizzaOrderId == i);
                if(sPOO.OrderId == null)
                {
                    sPOO.OrderId = order.OrderId;
                    _singlePizzaOrderRepository.Update(sPOO);
                }



            });


            return order.OrderId;


        }


    }
}
