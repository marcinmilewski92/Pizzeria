using Pizzeria.Domain.Entities;

namespace Pizzeria.Persistence.Repositories
{
    public interface IPizzaRepository : IGenericRepository<Pizza>
    {
        Task<IReadOnlyList<Pizza>> GetAllWithBaseIngredients();
        Task<Pizza?> GetPizzaWithBaseIngredients(int Id);
    }
}
