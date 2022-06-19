using GoberDinner.Application.Common.Interfaces.Services;

namespace GoberDinner.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}