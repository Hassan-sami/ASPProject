using Booking.Models.Data;

namespace Booking.viewModel
{
    public class DetailsViewModel
    {
        public User User { get; set; }

        public string UserId { get; set; }

        public int HotelId { get; set; }

        public string? HotelName { get; set; }

        public string? CityName { get; set; }

        public int NoOfAdults { get; set; } 

        public int NoOfChildren { get; set; }

        public Dictionary<int, int> RoomsId { get; set; }


        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }


        public  decimal TotalPrice { get; set; } 

    }
}
