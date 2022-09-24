using Application.DTOs.AddressDtos;
using Pizzeria.Domain.Entities;

namespace Application.Features
{
    public static class AddressComparer
    {
        /// <summary>
        /// Comparing Address and AddressDto objects.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="addressDto"></param>
        /// <returns>True when addresses are not null and have same properties values.</returns>

        public static bool AddressCompare(this Address address, AddressDto addressDto)
        {
            if (address != null &&
                addressDto != null &&
                addressDto.HouseNumber == address.HouseNumber &&
                addressDto.PhoneNumber == address.PhoneNumber &&
                addressDto.ApartmentNumber == address.ApartmentNumber &&
                addressDto.City == address.City &&
                addressDto.StreetName == address.StreetName &&
                addressDto.PostalCode == address.PostalCode &&
                addressDto.AddressId == address.AddressId)
            {
                return true;
            }
            return false;
        }
    }
}
