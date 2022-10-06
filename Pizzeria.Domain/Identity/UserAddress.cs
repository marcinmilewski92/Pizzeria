using Pizzeria.Domain.Entities;

namespace Pizzeria.Domain.Identity
{
    public class UserAddress : Address
    {
        public string UserId { get; set; } = string.Empty;

        public static explicit operator UserAddress(List<Address> v)
        {
            throw new NotImplementedException();
        }
    }
}
