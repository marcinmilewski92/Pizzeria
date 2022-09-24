using Application.Persistence.Contracts;
using Pizzeria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Persistence.Repositories
{
    public class AdditionalIngredientsRepository : GenericRepository<AdditionalIngredient>, IAdditionalIngredientRepository
    {
        private readonly PizzeriaDbContext _context;

        public AdditionalIngredientsRepository(PizzeriaDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
