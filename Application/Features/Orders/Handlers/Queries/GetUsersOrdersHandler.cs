using Application.DTOs.AdditionalIngedietDtos;
using Application.DTOs.OrdersDtos;
using Application.DTOs.SinglePizzaOrderDtos;
using Application.Features.Orders.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;

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

            var ordersDto = new List<UsersOrdersDto>();

            foreach (var order in orders)
            {
                var sprsDto = new List<SinglePizzaOrderForOrdersListDto>();
                foreach (var singlePizzaOrder in order.SinglePizzaOrders)
                {
                    var sprDto = new SinglePizzaOrderForOrdersListDto
                    {
                        SinglePizzaOrderId = singlePizzaOrder.SinglePizzaOrderId,
                        PizzaName = singlePizzaOrder.Pizza.Name,
                        AdditionalIngredients = _mapper.Map<List<AdditionalIngredietDto>>(singlePizzaOrder.AdditionalIngredients),
                        Price = singlePizzaOrder.Price,
                    };
                    sprsDto.Add(sprDto);
                }

                ordersDto.Add(new UsersOrdersDto
                {
                    OrderId = order.OrderId,
                    DateCreated = order.DateCreated,
                    SinglePizzaOrders = sprsDto,
                    FinalPrice = order.FinalPrice,

                });
            }
            return ordersDto;

            
        }
    }
}
