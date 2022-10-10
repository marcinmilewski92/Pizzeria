using Application.DTOs.AdditionalIngedietDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AdditionalIngredients.Requests.Queries
{
    public class GetAdditionalIngredientsQuery : IRequest<List<AdditionalIngredietDto>>
    {
    }
}
