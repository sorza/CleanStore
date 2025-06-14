﻿using CleanStore.Application.AccountContext.Repositories.Abstractions;
using CleanStore.Application.SharedContext.Repositories.Abstractions;
using CleanStore.Infrastructure.AccountContext.Repositories;
using CleanStore.Infrastructure.SharedContext.Data;
using Microsoft.Extensions.DependencyInjection;

namespace CleanStore.Infrastructure.SharedContext
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IUnityOfWork, UnitOfWork>();
            services.AddTransient<IAccountRepository, AccountRepository>();

            return services;
        }
    }
}
