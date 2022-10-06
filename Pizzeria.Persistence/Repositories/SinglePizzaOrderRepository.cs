using Application.Persistence.Contracts;
using Microsoft.EntityFrameworkCore;
using Pizzeria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Persistence.Repositories
{
    public class SinglePizzaOrderRepository : GenericRepository<SinglePizzaOrder>, ISinglePizzaOrderRepository
    {
        private readonly PizzeriaDbContext _context;

        public SinglePizzaOrderRepository(PizzeriaDbContext context) : base(context)
        {
            this._context = context;
        } 
        public async Task<SinglePizzaOrder> GetSinglePizzaOrderWithDetails(int id)
        {
            var singlePizzaOrder = await _context.SinglePizzaOrders
                .Include(p => p.AdditionalIngredients)
                .Include(p => p.Pizza).ThenInclude(p => p.BaseIngredients)
                .FirstOrDefaultAsync(p => p.SinglePizzaOrderId == id);

            if(singlePizzaOrder == null)
            {
                return null!;
            }

            return singlePizzaOrder;
        }
    }
}
