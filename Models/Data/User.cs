using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Booking.Models.Data
{
    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }


        public List<BookedRoom> BookedRooms { get; set; }

        public List<Trip> Trips { get; set; }

        public List<UserTrip> UserTrips { get; set; }

    }
}
