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
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly PizzeriaDbContext _context;

        public OrderRepository(PizzeriaDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Order?> GetOrderByIdWithDetail(int id)
        {
            return await _context.Orders.Include(o => o.DeliveryAddress)
                .Include(o => o.SinglePizzaOrders).ThenInclude(po => po.AdditionalIngredients)
                .Include(po => po.SinglePizzaOrders).ThenInclude(po => po.Pizza).ThenInclude(p => p.BaseIngredients)
                .FirstOrDefaultAsync(o => o.OrderId == id);


        }
    }
}
