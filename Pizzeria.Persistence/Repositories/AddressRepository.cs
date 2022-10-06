using Application.Persistence.Contracts;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Domain.Entities;
using Pizzeria.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Persistence.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        private readonly PizzeriaDbContext _context;

        public AddressRepository(PizzeriaDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Address>> GetAllOrderAddresses()
        {
            return await _context.Addresses.Where(a => !(a is UserAddress)).ToListAsync();
        }
    }
}
