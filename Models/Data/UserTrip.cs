using System.ComponentModel.DataAnnotations;

namespace Booking.Models.Data
{
    public class UserTrip
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public int TripId { get; set; }

        [Range(1,3)]
        [Required]
        public int NoOfAdults { get; set; }

        [Range(0,3)]
        public int NoOfChildern { get; set; }
        [Range (0,3)]
        public int NoOfInfant { get; set; }

        [Required]
        public DateTime DepartingDate { get; set; }

        public DateTime ReturningDate { get; set; }

        public User User { get; set; }

        public Trip Trip { get; set; }


    }


}
