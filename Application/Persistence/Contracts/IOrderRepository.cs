using Pizzeria.Domain.Entities;
using Pizzeria.Persistence.Repositories;

namespace Application.Persistence.Contracts
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<Order?> GetOrderByIdWithDetail (int id);
    }
}
