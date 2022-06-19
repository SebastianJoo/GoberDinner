using BuberDinner.Application.Common.Interfaces.Authentication;
using GoberDinner.Application.Common.Interfaces.Services;
using GoberDinner.Infrastructure.Authentication;
using GoberDinner.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GoberDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
    }
}