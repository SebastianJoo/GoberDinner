namespace GoberDinner.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string Token,
    string FirstName,
    string LastName);