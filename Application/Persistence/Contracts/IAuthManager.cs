﻿using Application.DTOs.UsersDtos;
using Microsoft.AspNetCore.Identity;
using Pizzeria.Domain.Identity;

namespace Application.Persistence.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(User user, string password);
        Task<Dictionary<string, string>> Login(string username, string password);
    }
}