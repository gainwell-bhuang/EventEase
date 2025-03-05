using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventEase.Models;

namespace EventEase.Services
{
     public class AttendanceService
    {
        private readonly Dictionary<int, List<Attendee>> _eventAttendees = new();

        public Task<bool> RegisterAttendee(Attendee attendee)
        {
            if (attendee == null || string.IsNullOrWhiteSpace(attendee.Name) || string.IsNullOrWhiteSpace(attendee.Email))
            {
                return Task.FromResult(false);
            }

            if (!_eventAttendees.ContainsKey(attendee.EventId))
            {
                _eventAttendees[attendee.EventId] = new List<Attendee>();
            }

            _eventAttendees[attendee.EventId].Add(attendee);
            return Task.FromResult(true);
        }

        public Task<List<Attendee>> GetAttendees(int eventId)
        {
            _eventAttendees.TryGetValue(eventId, out var attendees);
            return Task.FromResult(attendees ?? new List<Attendee>());
        }
    }
}