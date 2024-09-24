using Booking.customValidate;
using Booking.Models.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Booking.viewModel
{
    public class BookHotelViewModel
    {
        public User? User { get; set; }

        public List<City>? Cities { get; set; }

        [Required]
        [DisplayName("Hotel")]
        public string HotelName { get; set; }

        [Required]
        [DisplayName("City")]
        public string CityName { get; set; }

        [DisplayName("Check In")]
        [Required]
        [ValidDateHotel]
        public DateTime CheckIn { get; set; }

        [Required]
        [DisplayName("Check Out")]
       [DateCompareHotel]
        public DateTime CheckOut { get; set; }

        [Required]
        [Range(1, 5)]
        [DisplayName("Rooms")]
        public int NoOfRooms { get; set; }

        [Required]
        [Range(1, 5)]
        [DisplayName("Adults")]
        public int NoOfAdult { get; set; }

       


        [Required]
        [Range(0, 3)]
        [DisplayName("Children")]
        public int NoOfChildern { get; set; }
    }

    
}
