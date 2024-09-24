using Booking.Models.Data;

namespace Booking.viewModel
{
    public class HotelViewModel
    {
        public List<Hotel> Hotels { get; set; }

        public User? User { get; set; }

        public City City { get; set; }
    }
}
