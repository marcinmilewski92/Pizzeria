using Application.DTOs.PizzaDtos;
using Application.Features.Pizzas.Requests.Queries;
using AutoMapper;
using MediatR;
using Pizzeria.Domain.Entities;
using Pizzeria.Persistence.Repositories;

namespace Application.Features.Pizzas.Handlers.Queries
{
    public class GetPizzaListQueryHandler : IRequestHandler<GetPizzaListQuery, List<PizzaListDto>>
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IMapper _mapper;

        public GetPizzaListQueryHandler(IPizzaRepository pizzaRepository, IMapper mapper)
        {
            _pizzaRepository = pizzaRepository;
            _mapper = mapper;
        }
        public async Task<List<PizzaListDto>> Handle(GetPizzaListQuery request, CancellationToken cancellationToken)
        {
            var pizzas = await _pizzaRepository.GetAllWithBaseIngredients();

            var pizzasDto = _mapper.Map<List<PizzaListDto>>(pizzas);
            return pizzasDto;
        }
    }
}
