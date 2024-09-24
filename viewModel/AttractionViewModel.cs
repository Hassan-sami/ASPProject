using Booking.Models.Data;

namespace Booking.viewModel
{
    public class AttractionViewModel
    {
        public List<Hotel> TopHotels { get; set; }

        public  User? User { get; set; }
    }
}
