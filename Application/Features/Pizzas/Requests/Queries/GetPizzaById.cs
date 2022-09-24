using Application.DTOs.PizzaDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Pizzas.Requests.Queries
{
    public class GetPizzaByIdQuery : IRequest<PizzaDto>
    {
        public int Id { get; set; }
    }
}
