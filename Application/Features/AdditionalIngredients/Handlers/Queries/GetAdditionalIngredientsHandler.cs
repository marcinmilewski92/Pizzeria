using Application.DTOs.AdditionalIngedietDtos;
using Application.Features.AdditionalIngredients.Requests.Queries;
using Application.Persistence.Contracts;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AdditionalIngredients.Handlers.Queries
{
    public class GetAdditionalIngredientsHandler : IRequestHandler<GetAdditionalIngredientsQuery, List<AdditionalIngredietDto>>
    {
        private readonly IAdditionalIngredientRepository _additionalIngredientRepository;
        private readonly IMapper _mapper;

        public GetAdditionalIngredientsHandler(IAdditionalIngredientRepository additionalIngredientRepository, IMapper mapper)
        {
            this._additionalIngredientRepository = additionalIngredientRepository;
            this._mapper = mapper;
        }
        public async Task<List<AdditionalIngredietDto>> Handle(GetAdditionalIngredientsQuery request, CancellationToken cancellationToken)
        {
            var ingredients = await _additionalIngredientRepository.GetAll();
            return _mapper.Map<List<AdditionalIngredietDto>>(ingredients);
        }
    }
}
