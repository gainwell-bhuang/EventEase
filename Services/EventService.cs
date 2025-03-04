using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventEase.Models;

namespace EventEase.Services
{
   public class EventService : IEventService
    {
        private readonly List<Attendee> _attendees = new();
        private readonly List<Event> _events = new()
        {
            new Event { Id = 1, Name = "Tech Summit 2025", Date = new DateTime(2025, 6, 15), Location = "San Francisco, CA", Description = "A summit for tech enthusiasts." },
            new Event { Id = 2, Name = "Music Festival 2025", Date = new DateTime(2025, 7, 10), Location = "New York, NY", Description = "Enjoy a variety of music performances." },
            new Event { Id = 3, Name = "Wine & Food Festival 2025", Date = new DateTime(2025, 8,15), Location = "New York, NY", Description = "Enjoy a variety of foods and wines." }
        };

        public Task<List<Event>> GetEvents() => Task.FromResult(_events);

        public Task<Event?> GetEventById(int id) => Task.FromResult(_events.FirstOrDefault(e => e.Id == id));

         public Task<bool> RegisterForEvent(Attendee attendee)
        {
            if (attendee == null || string.IsNullOrWhiteSpace(attendee.Name) || string.IsNullOrWhiteSpace(attendee.Email))
            {
                return Task.FromResult(false);
            }

            _attendees.Add(attendee);

            // Add attendee to event
            var ev = _events.FirstOrDefault(e => e.Id == attendee.EventId);
            ev?.Attendees.Add(attendee);

            return Task.FromResult(true);
        }

        public Task<List<Attendee>> GetAttendeesForEvent(int eventId)
        {
            return Task.FromResult(_attendees.Where(a => a.EventId == eventId).ToList());
        }
    }
}