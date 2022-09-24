using Application.Persistence.Contracts;
using Pizzeria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Persistence.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly PizzeriaDbContext _context;

        public OrderRepository(PizzeriaDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
