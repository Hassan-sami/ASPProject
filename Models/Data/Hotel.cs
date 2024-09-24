using System.ComponentModel.DataAnnotations;

namespace Booking.Models.Data
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Image { get; set; }

        public int CityId { get; set; }

        public string? Description { get; set; }


        [Range(0, 7)]
        public int StarsNo { get; set; }

        public City City { get; set; }

        public List<Room> Rooms { get; set; }

        public List<HotelRoom> HotelRooms { get; set; }


    }
}
