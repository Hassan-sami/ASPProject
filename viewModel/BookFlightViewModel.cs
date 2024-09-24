using Booking.customValidate;
using Booking.Models.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Booking.viewModel
{
    public class BookFlightViewModel
    {
        public User? User { get; set; }

        public List<City>? Cities { get; set; }

        [Required]
        [DisplayName("Leaving from")]
        public string From { get; set; }

        [Required]
        [DisplayName("Going to")]
        public string To { get; set; }

        [Required]
        [ValidDate]
        [DisplayName("Departing")]

        public DateTime DepartingDate { get; set; }

        [DateCompare]
        [DisplayName("Returning")]
        public DateTime ReturningDate { get; set; }

        [Required]
        [Range(1,3)]
        [DisplayName("Adults")]
        public int NoOfAdult { get; set; }

        public TypeOfTrip TypeOfTrip { get; set; } 


        

        [Required]
        [Range(0, 3)]
        [DisplayName("Children")]
        public int NoOfChildern { get; set; }

        [Required]
        [Range(0, 3)]
        [DisplayName("Infant")]
        public int NoOfInfant { get; set; }
    }

    public enum TypeOfTrip
    {
        RoundTrip,
        OneWayTrip
    }
}
