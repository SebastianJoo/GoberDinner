using GoberDinner.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace GoberDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplictation(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}