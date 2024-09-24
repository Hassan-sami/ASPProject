using Booking.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Models.Configuration
{
    public class HotelRoomConfiguration : IEntityTypeConfiguration<HotelRoom>
    {
        public void Configure(EntityTypeBuilder<HotelRoom> builder)
        {
            HotelRoom[] hotelRooms = new HotelRoom[]
            {
                new HotelRoom {HotelId = 1,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 1,RoomId = 2, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 100},
                new HotelRoom {HotelId = 1,RoomId = 4, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 130},
                new HotelRoom {HotelId = 1,RoomId = 6, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 150},

                new HotelRoom {HotelId = 2,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 2,RoomId = 2, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 100},
                new HotelRoom {HotelId = 2,RoomId = 4, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 130},

                new HotelRoom {HotelId = 3,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 3,RoomId = 2, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 100},
                new HotelRoom {HotelId = 3,RoomId = 4, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 130},
                new HotelRoom {HotelId = 3,RoomId = 6, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 150},

                new HotelRoom {HotelId = 4,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 4,RoomId = 2, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 100},
                new HotelRoom {HotelId = 4,RoomId = 4, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 130},
                new HotelRoom {HotelId = 4,RoomId = 6, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 150},

                new HotelRoom {HotelId = 5,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 5,RoomId = 2, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 100},
                new HotelRoom {HotelId = 5,RoomId = 4, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 130},
                new HotelRoom {HotelId = 5,RoomId = 6, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 150},


                new HotelRoom {HotelId = 6,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 6,RoomId = 2, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 100},
                new HotelRoom {HotelId = 6,RoomId = 4, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 130},
                new HotelRoom {HotelId = 6,RoomId = 6, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 150},
                new HotelRoom {HotelId = 6,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},

                new HotelRoom {HotelId = 7,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 7,RoomId = 2, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 100},
                new HotelRoom {HotelId = 7,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 7,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 7,RoomId = 6, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 150},



                new HotelRoom {HotelId = 8,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 8,RoomId = 2, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 100},
                new HotelRoom {HotelId = 8,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 8,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},

                new HotelRoom {HotelId = 9,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 9,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 9,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 9,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 9,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 9,RoomId = 6, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 150},
                new HotelRoom {HotelId = 9,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},


                new HotelRoom {HotelId = 10,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 10,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 10,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 10,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 10,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 10,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 10,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 11,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 11,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 11,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 11,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 11,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 11,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 11,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 11,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},




                new HotelRoom {HotelId = 12,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 12,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 12,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 12,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 12,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 12,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 12,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 12,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},



                new HotelRoom {HotelId = 13,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 13,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 13,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 13,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 13,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 13,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 13,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 13,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},



                new HotelRoom {HotelId = 14,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 14,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 14,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 14,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 14,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 14,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 14,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},



                new HotelRoom {HotelId = 15,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 15,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 15,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 15,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 15,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 15,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 15,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},



                new HotelRoom {HotelId = 16,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 16,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 16,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 16,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 16,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 16,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 16,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 16,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},



                new HotelRoom {HotelId = 17,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 17,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 17,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 17,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 17,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 17,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 17,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 17,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},




                new HotelRoom {HotelId = 18,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 18,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 18,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 18,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 18,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 18,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 18,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 18,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},


                new HotelRoom {HotelId = 19,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 19,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 19,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 19,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 19,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 19,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 19,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},




                new HotelRoom {HotelId = 20,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 20,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 20,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 20,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 20,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 20,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 20,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 20,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},


                new HotelRoom {HotelId = 21,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 21,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 21,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 21,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 21,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 21,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 21,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 21,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},

                new HotelRoom {HotelId = 22,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 22,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 22,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 22,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 22,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},




                new HotelRoom {HotelId = 23,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 23,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 23,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 23,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 23,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 23,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 23,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 24,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 24,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 24,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 24,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 24,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 24,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 24,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 24,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},


                new HotelRoom {HotelId = 25,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 25,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 25,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 25,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 25,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 25,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 25,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 26,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 26,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 26,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 26,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 26,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 26,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 26,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 27,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 27,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 27,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 27,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 27,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 27,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 27,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 28,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 28,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 28,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 28,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 28,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 28,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 28,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 29,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 29,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 29,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 29,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 29,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 29,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 29,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 30,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 30,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 30,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 30,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 30,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 30,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 30,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},



                new HotelRoom {HotelId = 31,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 31,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 31,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 31,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 31,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 31,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 31,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 32,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 32,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 32,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 32,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 32,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 32,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 32,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 33,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 33,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 33,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 33,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 33,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 33,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 33,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 34,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 34,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 34,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 34,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 34,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 34,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 34,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 35,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 35,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 35,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 35,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 35,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},

                new HotelRoom {HotelId = 36,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 36,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 36,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 36,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 36,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 36,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 36,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 37,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 37,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 37,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 37,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 37,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 37,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 37,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 38,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 38,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 38,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 38,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 38,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 38,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 38,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 39,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 39,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 39,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 39,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 39,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 39,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 39,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 40,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 40,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 40,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 40,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 40,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 40,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 40,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 41,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 41,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 41,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 41,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 41,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 41,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 41,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 41,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},


                new HotelRoom {HotelId = 42,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 42,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 42,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 42,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 42,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 42,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 42,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 42,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},


                new HotelRoom {HotelId = 43,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 43,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 43,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 43,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 43,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 43,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 43,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 43,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},



                new HotelRoom {HotelId = 44,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 44,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 44,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 44,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 44,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 44,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 44,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 45,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 45,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 45,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 45,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 45,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 45,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 45,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 45,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},


                new HotelRoom {HotelId = 46,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 46,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 46,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 46,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 46,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},


                new HotelRoom {HotelId = 47,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 47,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 47,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 47,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 47,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},


                new HotelRoom {HotelId = 48,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 48,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 48,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 48,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 48,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 48,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 48,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},



                new HotelRoom {HotelId = 49,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 49,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 49,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 49,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 49,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 49,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 49,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},



                new HotelRoom {HotelId = 50,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 50,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 50,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 50,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 50,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 50,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 50,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 50,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},



                new HotelRoom {HotelId = 51,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 51,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 51,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 51,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 51,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 51,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 51,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 52,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 52,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 52,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 52,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 52,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 52,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 52,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 52,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},


                new HotelRoom {HotelId = 53,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 53,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 53,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 53,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 53,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 53,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 53,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 54,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 54,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 54,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 54,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 54,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 54,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 54,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 55,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 55,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 55,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 55,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 55,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 55,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 55,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},



                new HotelRoom {HotelId = 56,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 56,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 56,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 56,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 56,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 56,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 56,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 56,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},


                new HotelRoom {HotelId = 57,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 57,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 57,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 57,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 57,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},


                new HotelRoom {HotelId = 58,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 58,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 58,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 58,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 58,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 58,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 58,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 59,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 59,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 59,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 59,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 59,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 59,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 59,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 59,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},



                new HotelRoom {HotelId = 60,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 60,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 60,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 60,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 60,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 60,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 60,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 61,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 61,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 61,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 61,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 61,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 61,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 61,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 62,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 62,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 62,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 62,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 62,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 62,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 62,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 63,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 63,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 63,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 63,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 63,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},


                new HotelRoom {HotelId = 64,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 64,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 64,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 64,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 64,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 64,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 64,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 65,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 65,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 65,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 65,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 65,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},



                new HotelRoom {HotelId = 66,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 66,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 66,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 66,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 66,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 66,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 66,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 67,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 67,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 67,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 67,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 67,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 67,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 67,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},



                new HotelRoom {HotelId = 68,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 68,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 68,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 68,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 68,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 68,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 68,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 69,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 69,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 69,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 69,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 69,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 69,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 69,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 70,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 70,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 70,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 70,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 70,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 70,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 70,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 71,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 71,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 71,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 71,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 71,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 71,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 71,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 72,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 72,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 72,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 72,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 72,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},


                new HotelRoom {HotelId = 73,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 73,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 73,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 73,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 73,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 73,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 73,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 74,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 74,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 74,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 74,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 74,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 74,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 74,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 75,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 75,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 75,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 75,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 75,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},


                new HotelRoom {HotelId = 76,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 76,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 76,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 76,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 76,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 76,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 76,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 76,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},

                new HotelRoom {HotelId = 77,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 77,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 77,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 77,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 77,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 77,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 77,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 78,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 78,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 78,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 78,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 78,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 78,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 78,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 78,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},

                new HotelRoom {HotelId = 79,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 79,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 79,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 79,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 79,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 79,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 79,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 80,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 80,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 80,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 80,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 80,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 80,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 80,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 80,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},

                new HotelRoom {HotelId = 81,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 81,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 81,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 81,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 81,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 81,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 81,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 81,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},

                new HotelRoom {HotelId = 82,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 82,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 82,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 82,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 82,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 82,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 82,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 83,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 83,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 83,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 83,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 83,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 83,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 83,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 83,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},


                new HotelRoom {HotelId = 84,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 84,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 84,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 84,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 84,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},


                new HotelRoom {HotelId = 85,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 85,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 85,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 85,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 85,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 85,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 85,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 86,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 86,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 86,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 86,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 86,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 86,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 86,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 87,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 87,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 87,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 87,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 87,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},


                new HotelRoom {HotelId = 88,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 88,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 88,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 88,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 88,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 88,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 88,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
            
                new HotelRoom {HotelId = 89,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 89,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 89,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 89,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 89,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 89,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 89,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 90,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 90,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 90,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 90,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 90,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 90,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 90,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 91,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 91,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 91,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 91,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 91,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 91,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 91,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 92,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 92,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 92,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 92,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 92,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 92,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 92,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 93,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 93,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 93,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 93,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 93,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 93,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 93,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 94,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 94,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 94,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 94,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 94,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 94,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 94,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 95,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 95,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 95,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 95,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 95,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 95,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 95,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 96,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 96,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 96,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 96,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 96,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 96,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 96,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 97,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 97,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 97,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 97,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 97,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 97,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 97,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 98,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 98,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 98,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 98,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 98,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 98,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 98,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 99,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 99,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 99,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 99,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 99,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 99,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 99,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

          
                new HotelRoom {HotelId = 100,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 100,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 100,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 100,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 100,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},


                new HotelRoom {HotelId = 101,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 101,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 101,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 101,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 101,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 101,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 101,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 102,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 102,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 102,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 102,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 102,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},


                new HotelRoom {HotelId = 103,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 103,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 103,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 103,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 103,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 103,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 103,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 104,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 104,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 104,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 104,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 104,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},


                new HotelRoom {HotelId = 105,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 105,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 105,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 105,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 105,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 105,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 105,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 106,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 106,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 106,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 106,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 106,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 106,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 106,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 107,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 107,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 107,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 107,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 107,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 107,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 107,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 108,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 108,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 108,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 108,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 108,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 108,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 108,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 109,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 109,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 109,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 109,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 109,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 109,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 109,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 110,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 110,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 110,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 110,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 110,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 110,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 110,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 110,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},


                new HotelRoom {HotelId = 111,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 111,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 111,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 111,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 111,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 111,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 111,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 111,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},

                new HotelRoom {HotelId = 112,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 112,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 112,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 112,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 112,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 112,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 112,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 113,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 113,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 113,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 113,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 113,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 113,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 113,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},


                new HotelRoom {HotelId = 114,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 114,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 114,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 114,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 114,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 114,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 114,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 114,RoomId = 8, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 160},


                new HotelRoom {HotelId = 115,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 115,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 115,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 115,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 115,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 115,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 115,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 116,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 116,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 116,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 116,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 116,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 116,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 116,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 117,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 117,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 117,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 117,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 117,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 117,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 117,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 118,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 118,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 118,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 118,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 118,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 118,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 118,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

                new HotelRoom {HotelId = 119,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 119,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 119,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 119,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 119,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},

                new HotelRoom {HotelId = 120,RoomId = 1, TotalNoOfThisRoomPerHotel = 10,PricePerNight = 50},
                new HotelRoom {HotelId = 120,RoomId = 2, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 120,RoomId = 3, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 100},
                new HotelRoom {HotelId = 120,RoomId = 4, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 120,RoomId = 5, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 130},
                new HotelRoom {HotelId = 120,RoomId = 6, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},
                new HotelRoom {HotelId = 120,RoomId = 7, TotalNoOfThisRoomPerHotel = 5,PricePerNight = 150},

            };

            builder.HasData(hotelRooms);


        }
    }
}
