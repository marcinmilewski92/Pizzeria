using Application.Features.SinglePizzaOrders.Requests.Commands;
using Application.Persistence.Contracts;
using MediatR;
using Pizzeria.Domain.Entities;
using Pizzeria.Persistence.Repositories;

namespace Application.Features.SinglePizzaOrders.Handlers.Commands
{
    public class CreateSinglePizzaOrderCommandHandler : IRequestHandler<CreateSinglePizzaOrderCommand, int?>
    {
        private readonly ISinglePizzaOrderRepository _singlePizzaOrderRepository;
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IAdditionalIngredientRepository _additionalIngredientRepository;

        public CreateSinglePizzaOrderCommandHandler(ISinglePizzaOrderRepository singlePizzaOrderRepository,IPizzaRepository pizzaRepository, IAdditionalIngredientRepository addableIngredientRepository)
        {
            this._singlePizzaOrderRepository = singlePizzaOrderRepository;
            this._pizzaRepository = pizzaRepository;
            this._additionalIngredientRepository = addableIngredientRepository;
        }
        public async Task<int?> Handle(CreateSinglePizzaOrderCommand request, CancellationToken cancellationToken)
        {

            var pizza = await _pizzaRepository.GetPizzaWithBaseIngredients(request.SinglePizzaOrderCreateDto.PizzaId);
            
            if(pizza == null)
            {
                return null;
            }


            var addableIngredients = new List<AdditionalIngredient>();

            foreach(var requestIngredientId in request.SinglePizzaOrderCreateDto.AdditionalIngredientsIds)
            {
                var ingridientFromDatabase = await _additionalIngredientRepository.Get(requestIngredientId);

                if(ingridientFromDatabase != null)
                {
                    addableIngredients.Add(ingridientFromDatabase);
                }
                    
            }

            var siglePizzaOrder = new SinglePizzaOrder()
            {
                Pizza = pizza,
                AdditionalIngredients = addableIngredients,
                CurrentPizzaPrice = pizza.Price
            };

            siglePizzaOrder = await _singlePizzaOrderRepository.Add(siglePizzaOrder);

            return siglePizzaOrder.SinglePizzaOrderId;



        }
    }
}
