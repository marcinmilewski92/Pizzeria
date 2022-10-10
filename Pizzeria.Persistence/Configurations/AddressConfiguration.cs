using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzeria.Domain.Identity;

namespace Pizzeria.Persistence.Configurations
{
    public partial class RoleConfiguration
    {
        public class AddressConfiguration : IEntityTypeConfiguration<UserAddress>
        {
            public void Configure(EntityTypeBuilder<UserAddress> builder)
            {

                builder.HasData(
                    new UserAddress
                    {
                        AddressId = 1,
                        StreetName = "default",
                        City = "default",
                        PostalCode = "default",
                        ApartmentNumber = "default",
                        HouseNumber = "default",
                        PhoneNumber = "default",
                        UserId = "b1f97c6d-6b0f-4f27-b6c7-aa9a27ed8b0e",

                    },
                    new UserAddress
                    {
                        AddressId = 2,
                        StreetName = "default",
                        City = "default",
                        PostalCode = "default",
                        ApartmentNumber = "default",
                        HouseNumber = "default",
                        PhoneNumber = "default",
                        UserId = "5b2d14fc-852b-4e0b-81f9-3ac8393b0638"

                    }
                );
            }
        }
    }
}
