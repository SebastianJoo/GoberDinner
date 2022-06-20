using GoberDinner.Domain.Entities;

namespace GoberDinner.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token
    );