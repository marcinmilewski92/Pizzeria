using Application.Persistence.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Pizzeria.Domain.Entities;
using Pizzeria.Domain.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Pizzeria.Persistence.Repositories
{
    public class AuthAndUserManager : IAuthAndUserManager
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;

        public AuthAndUserManager(UserManager<User> userManager, IConfiguration configuration)
        {
            this._userManager = userManager;
            this._configuration = configuration;
        }

        public async Task<IEnumerable<Order>> GetUsersOreders(string userName)
        {
            var user = await _userManager.Users
                .Include(u => u.Orders).ThenInclude(o => o.SinglePizzaOrders).ThenInclude(spo => spo.AdditionalIngredients)
                .Include(o => o.Orders).ThenInclude(o => o.SinglePizzaOrders).ThenInclude(spo => spo.Pizza)
                .FirstOrDefaultAsync(u => u.UserName == userName);
            return user.Orders.ToList();
        }


        public async Task<Dictionary<string, string>> Login(string userName, string password)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var validPassword = await _userManager.CheckPasswordAsync(user, password);


            if(validPassword)
            {
                var token = await GenerateToken(user);

                return new Dictionary<string, string>()
                {
                    { "token", token  },
                    { "userId", user.Id },
                };
            }
            return null!;
        }

        public async Task<IEnumerable<IdentityError>> Register(User user, string password)
        {
            user.UserName = user.Email;
            var result = await _userManager.CreateAsync(user, password);

            if(result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }

            return result.Errors;
        }

        private async Task<string> GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = roles.Select(r => new Claim(ClaimTypes.Role, r)).ToList();

            var userClaims = await _userManager.GetClaimsAsync(user);

            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)

            }
            .Union(userClaims).Union(roleClaims);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims : claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JwtSettings:DurationInMinutes"])),
                signingCredentials: credentials
                
                
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
