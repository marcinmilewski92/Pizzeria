using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.Configurations
{
    public partial class RoleConfiguration
    {
        public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
        {
            public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
            {
                builder.HasData(
                         new IdentityUserRole<string>()
                {
         RoleId = "b1f97c6d-6b0f-4f27-b6c7-aa9a27ed8b0d",
         UserId = "b1f97c6d-6b0f-4f27-b6c7-aa9a27ed8b0e"
             },
     new IdentityUserRole<string>()
     {
         RoleId = "5b2d14fc-852b-4e0b-81f9-3ac8393b0637",
         UserId = "5b2d14fc-852b-4e0b-81f9-3ac8393b0638"
     }
                );
            }
        }
    }
}
