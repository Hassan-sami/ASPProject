using Booking.customValidate;
using Booking.Models.Repo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.Models.Data
{
    public class Room
    {
        public int Id { get; set; }

        public int BedNo { get; set; }

        public string Type { get; set; }

        public string BedType { get; set; }

        [CustomRange]
        public int ResidentNo { get; set; }

        public List<Hotel> Hotels { get; set; }

        public List<HotelRoom> HotelRooms { get; set; }

    }
}
