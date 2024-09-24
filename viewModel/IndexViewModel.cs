using Booking.Models.Data;

namespace Booking.viewModel
{
    public class IndexViewModel
    {
        public List<City> Cities { get; set; }

        public List<Hotel> Hotels { get; set; }

        public User? User { get; set; }
        public List<City> TopCities { get; set; }

    }
}
