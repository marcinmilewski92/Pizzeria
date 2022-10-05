using Application.Services.Contracts;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
        }
        public async Task<string> GetUserName(HttpContext context)
        {
            
            var token = context.Request.Headers["Authorization"].ToString().Substring("Bearer ".Length);

            var claims = new JwtSecurityTokenHandler().ReadJwtToken(token).Claims.ToList();

            var sub = claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub).Value;

            await Task.CompletedTask;

            return sub;
            
        }

    }
}
