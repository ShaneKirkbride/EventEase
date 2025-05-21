namespace EventEase2.Models;

using System.ComponentModel.DataAnnotations;

public class EventRegistrationDto
{
    public Guid EventId { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string Email { get; set; } = string.Empty;

    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
}
