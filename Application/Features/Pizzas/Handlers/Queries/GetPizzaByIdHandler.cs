using Application.DTOs.PizzaDtos;
using Application.Features.Pizzas.Requests.Queries;
using AutoMapper;
using MediatR;
using Pizzeria.Persistence.Repositories;

namespace Application.Features.Pizzas.Handlers.Queries
{
    public class GetPizzaByIdQueryHandler : IRequestHandler<GetPizzaByIdQuery, PizzaDto>
    {
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IMapper _mapper;

        public GetPizzaByIdQueryHandler(IPizzaRepository pizzaRepository, IMapper mapper)
        {
            _pizzaRepository = pizzaRepository;
            _mapper = mapper;
        }
        public async Task<PizzaDto> Handle(GetPizzaByIdQuery request, CancellationToken cancellationToken)
        {
            var pizza = await _pizzaRepository.GetPizzaWithBaseIngredients(request.Id);

            if (pizza == null)
            {
                return null!;
            }

            var pizzaDto = _mapper.Map<PizzaDto>(pizza);

            return pizzaDto;
        }
    }
}
