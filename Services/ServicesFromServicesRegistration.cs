﻿using Application.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServicesFromServicesRegistration
    {
        public static IServiceCollection ConfigureServicesFromServices(this IServiceCollection services)
        {

            services.AddScoped<IUserService, UserService>();

            return services;
        }

    }
}
