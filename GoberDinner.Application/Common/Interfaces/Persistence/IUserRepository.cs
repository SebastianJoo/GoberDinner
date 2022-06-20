using GoberDinner.Domain.Entities;

namespace GoberDinner.Application.Common.Interfaces.Persistence;
public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}