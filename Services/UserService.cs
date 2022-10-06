using Application.Services.Contracts;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;

namespace Services
{
    public class UserService : IUserService
    {
        public async Task<string> GetUserName(HttpContext context)
        {
            
            var token = context.Request.Headers["Authorization"].ToString()["Bearer ".Length..];

            var claims = new JwtSecurityTokenHandler().ReadJwtToken(token).Claims.ToList();

            var sub = claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub)!.Value;

            await Task.CompletedTask;

            return sub;
        }
        public async Task<string> GetUserId(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].ToString()["Bearer ".Length..];

            var claims = new JwtSecurityTokenHandler().ReadJwtToken(token).Claims.ToList();

            var uId = claims.FirstOrDefault(c => c.Type == "uid")!.Value;

            await Task.CompletedTask;

            return uId;
        }


    }
}
