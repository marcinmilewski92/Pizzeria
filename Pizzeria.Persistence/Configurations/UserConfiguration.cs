using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzeria.Domain.Identity;

namespace Pizzeria.Persistence.Configurations
{
    public partial class RoleConfiguration
    {
        public class UserConfiguration : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                builder.HasData(
                    new User
                    {
                        Id = "b1f97c6d-6b0f-4f27-b6c7-aa9a27ed8b0e",
                        UserName = "user@pizza.com",
                        NormalizedUserName = "USER@PIZZA.COM",
                        Email = "user@pizza.com",
                        PasswordHash = "AQAAAAEAACcQAAAAEAtO+NnczwINpeoj1erXPTwTf6NrP8iBDdL/NYj+xiVqnkznu3E2P/gEE+ZnwQoRjA==", // P@ssword1
                    });

                builder.HasData(
                    new User
                    {
                        Id = "5b2d14fc-852b-4e0b-81f9-3ac8393b0638",
                        UserName = "admin@pizza.com",
                        NormalizedUserName = "ADMIN@PIZZA.COM",
                        Email = "admin@pizza.com",
                        PasswordHash = "AQAAAAEAACcQAAAAEAtO+NnczwINpeoj1erXPTwTf6NrP8iBDdL/NYj+xiVqnkznu3E2P/gEE+ZnwQoRjA==", // P@ssword1
                    }
                    );
            }
        }
    }
}
