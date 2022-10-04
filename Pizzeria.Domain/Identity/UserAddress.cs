using Pizzeria.Domain.Entities;

namespace Pizzeria.Domain.Identity
{
    public class UserAddress : Address
    {
        public string UserId { get; set; } = string.Empty;
    }
}
