using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventEase.Models;

namespace EventEase.Services
{
    public interface IEventService
    {
        Task<List<Event>> GetEvents();
        Task<Event?> GetEventById(int id);

        Task<bool> RegisterForEvent(Attendee attendee);
        Task<List<Attendee>> GetAttendeesForEvent(int eventId);
    }
}