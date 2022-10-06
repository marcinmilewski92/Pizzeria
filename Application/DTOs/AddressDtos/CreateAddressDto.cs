namespace Application.DTOs.AddressDtos
{
    public class CreateAddressDto
    {
        public string StreetName { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string ApartmentNumber { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
