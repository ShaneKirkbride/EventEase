using EventEase2.Models;

namespace EventEase2.Services;

public interface IEventService
{
    Task<IEnumerable<EventDto>> GetEventsAsync();
    Task<EventDto> GetEventByIdAsync(Guid id);
    Task<List<EventDto>> GetUpcomingEventsAsync();

}