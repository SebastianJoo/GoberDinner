using GoberDinner.Application;
using GoberDinner.Application.Services.Authentication;
using GoberDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();

    app.Run();
}