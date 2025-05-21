using EventEase2.Models;
using EventEase2.Services;

public class MockEventService : IEventService
{
    private static readonly List<EventDto> Events = new()
    {
        new EventDto
        {
            Id = Guid.NewGuid(),
            Name = "Blazor Bootcamp",
            Date = DateTime.UtcNow.AddDays(5),
            Location = "Online"
        },
        new EventDto
        {
            Id = Guid.NewGuid(),
            Name = "Tech Leadership Summit",
            Date = DateTime.UtcNow.AddDays(10),
            Location = "Denver, CO"
        }
    };

    public Task<IEnumerable<EventDto>> GetEventsAsync() => Task.FromResult<IEnumerable<EventDto>>(Events);

    public Task<EventDto> GetEventByIdAsync(Guid id)
    {
        var evt = Events.FirstOrDefault(e => e.Id == id);
        return evt is not null
            ? Task.FromResult(evt)
            : throw new KeyNotFoundException("EventDto not found");
    }

    public Task<List<EventDto>> GetUpcomingEventsAsync()
    {
        var now = DateTime.UtcNow;
        return Task.FromResult(Events.Where(e => e.Date >= now).ToList());
    }

}