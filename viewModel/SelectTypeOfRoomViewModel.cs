using Booking.customValidate;
using Booking.Models.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Booking.viewModel
{
    public class SelectTypeOfRoomViewModel
    {

        public List<int>? BookedId { get; set; }

        public List<Room>? Rooms { get; set;}
        public User? User { get; set; }

        public int HotelId { get; set; }
        
        public string UserId { get; set; }
        public string HotelName { get; set; }

        public string CityName { get; set; }

       
        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        
        public int NoOfRooms { get; set; }

       
        public int NoOfAdults { get; set; }

        public int NoOfChildern { get; set; }
    }
}
