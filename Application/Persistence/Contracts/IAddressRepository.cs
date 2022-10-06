using Pizzeria.Domain.Entities;
using Pizzeria.Persistence.Repositories;

namespace Application.Persistence.Contracts
{
    public interface IAddressRepository : IGenericRepository<Address>
    {
        public Task<IEnumerable<Address>> GetAllOrderAddresses();
    }
}