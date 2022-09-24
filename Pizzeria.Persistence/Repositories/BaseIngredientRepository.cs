using Pizzeria.Domain.Entities;

namespace Pizzeria.Persistence.Repositories
{
    public class BaseIngredientRepository : GenericRepository<BaseIngredient>, IBaseIngredientRepository
    {
        private readonly PizzeriaDbContext _context;

        public BaseIngredientRepository(PizzeriaDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
