using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Booking.Models.Data
{
    public class BookedRoom
    {
        public int Id { get; set; }    
        [Required]
        public string UserId { get; set; }

        public int HotelId { get; set; }


        public int RoomId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int NoOfRooms { get; set; }

        public User User { get; set; }

        public Hotel Hotel { get; set; }

        public Room Room { get; set; }





    }
}
