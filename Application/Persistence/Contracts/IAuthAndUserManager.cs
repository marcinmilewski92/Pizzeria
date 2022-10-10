using Application.DTOs.UsersDtos;
using Microsoft.AspNetCore.Identity;
using Pizzeria.Domain.Entities;
using Pizzeria.Domain.Identity;

namespace Application.Persistence.Contracts
{
    public interface IAuthAndUserManager
    {
        Task<IEnumerable<IdentityError>> Register(User user, string password);
        Task<Dictionary<string, string>> Login(string username, string password);
        Task<IEnumerable<Order>> GetUsersOreders(string userId);
    }
}
