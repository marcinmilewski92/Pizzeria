namespace Pizzeria.Domain.Entities
{
    public class Address : IEntity
    {
        public int AddressId { get; set; }
        public string StreetName { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string ApartmentNumber { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public List<Order> Orders { get; set; }

        public Address()
        {
            Orders = new List<Order>();
        }

    }
}