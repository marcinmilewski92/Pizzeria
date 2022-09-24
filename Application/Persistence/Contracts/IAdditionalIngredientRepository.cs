using Pizzeria.Domain.Entities;
using Pizzeria.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistence.Contracts
{
    public interface IAdditionalIngredientRepository : IGenericRepository<AdditionalIngredient>
    {
    }
}
