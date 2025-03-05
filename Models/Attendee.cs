using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventEase.Models
{
   public class Attendee
    {
        public int Id { get; set; }  // Unique identifier
         [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = string.Empty;

        // Foreign key to link attendees with an event
        public int EventId { get; set; }
        public Event? Event { get; set; }
    }

}