using Pizzeria.Domain.Entities;

namespace Pizzeria.Persistence.Repositories
{
    public interface IGenericRepository<T> where T : IEntity
    {
        Task<T?> Get(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<bool> Exists(int id);
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);

    }
}
