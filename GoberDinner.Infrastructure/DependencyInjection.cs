using BuberDinner.Application.Common.Interfaces.Authentication;
using GoberDinner.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace GoberDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
    }
}