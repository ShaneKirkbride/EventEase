using EventEase2.Models;

namespace EventEase2.Services;

public interface IRegistrationService
{
    Task RegisterAsync(EventRegistrationDto registration);

    Task<List<EventRegistrationDto>> GetRegistrationsForEventAsync(Guid eventId);
}
