using System.Collections.Generic;

namespace EventEaseApp;

public class EventStateService
{
    public List<Attendee> Attendees { get; } = new();

    public void AddAttendee(string name, string email)
    {
        Attendees.Add(new Attendee
        {
            Name = name,
            Email = email
        });
    }
}

public class Attendee
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
