using Booking.Models.Data;

namespace Booking.viewModel
{
    public class ConfirmationViewModel
    {
        public User User { get; set; }

        public UserTrip UserTrip { get; set; }

        public Trip Trip { get; set; }
    }
}
