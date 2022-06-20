using BuberDinner.Application.Common.Interfaces.Authentication;
using GoberDinner.Application.Common.Interfaces.Persistence;
using GoberDinner.Application.Common.Interfaces.Services;
using GoberDinner.Infrastructure.Authentication;
using GoberDinner.Infrastructure.Persistence;
using GoberDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoberDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}