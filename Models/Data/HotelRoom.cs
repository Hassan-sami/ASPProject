﻿using System.ComponentModel.DataAnnotations;

namespace Booking.Models.Data
{
    public class HotelRoom
    {
        public int HotelId { get; set; }

        public int RoomId { get; set; }

        public int TotalNoOfThisRoomPerHotel { get; set; }


        [Required]
        public decimal PricePerNight { get; set; }

        public Hotel Hotel { get; set; }

        public Room Room { get; set; }


    }
}
