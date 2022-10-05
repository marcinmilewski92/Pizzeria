using Microsoft.AspNetCore.Http;

namespace Application.Services.Contracts
{
    public interface IUserService
    {
        Task<string> GetUserName(HttpContext context);
    }
}
