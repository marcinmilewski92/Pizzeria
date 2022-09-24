using Microsoft.EntityFrameworkCore;
using Pizzeria.Domain.Entities;

namespace Pizzeria.Persistence.Repositories
{
    public class PizzaRepository : GenericRepository<Pizza>, IPizzaRepository
    {
        private readonly PizzeriaDbContext _context;

        public PizzaRepository(PizzeriaDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<IReadOnlyList<Pizza>> GetAllWithBaseIngredients()
        {
            return await _context.Pizzas.Include(p => p.BaseIngredients).ToListAsync();
        }

        public async Task<Pizza?> GetPizzaWithBaseIngredients(int Id)
        {
            return await _context.Pizzas.Include(p => p.BaseIngredients).FirstOrDefaultAsync(p => p.PizzaId == Id);
        }
    }
}
