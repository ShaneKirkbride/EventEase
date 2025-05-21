using EventEase2.Models;

namespace EventEase2.Services;

public class MockRegistrationService : IRegistrationService
{
    private readonly List<EventRegistrationDto> _registrations = new();

    public Task RegisterAsync(EventRegistrationDto registration)
    {
        _registrations.Add(registration); // simulate persistence
        Console.WriteLine($"Registered {registration.Name} for event {registration.EventId}");
        return Task.CompletedTask;
    }

    public Task<List<EventRegistrationDto>> GetRegistrationsForEventAsync(Guid eventId)
    {
        var results = _registrations
            .Where(r => r.EventId == eventId)
            .ToList();
        return Task.FromResult(results);
    }


    public IReadOnlyList<EventRegistrationDto> GetAll() => _registrations;
}
