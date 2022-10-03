using Microsoft.AspNetCore.Identity;
using Pizzeria.Domain.Entities;

namespace Pizzeria.Domain.Identity
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public UserAddress UserAddress { get; set; } = new UserAddress();
        IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}
