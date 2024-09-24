using Booking.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Models.Configuration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");
            builder.HasKey(x => x.Id);

            Room[] Rooms = new Room[]
                {
                    new Room {Id = 1 ,Type = "Single",ResidentNo = 1, BedNo = 1, BedType = "single bed"},
                    new Room {Id = 2 ,Type = "Double",ResidentNo = 2, BedNo = 2, BedType = "single bed"},
                    new Room {Id = 3 ,Type = "Double",ResidentNo = 2, BedNo = 1, BedType = "double bed"},
                    new Room {Id = 4 ,Type = "Triple",ResidentNo = 3, BedNo = 3, BedType = "twin bed"},
                    new Room {Id = 5 ,Type = "Triple",ResidentNo = 3, BedNo = 2, BedType = "double bed"},
                    new Room {Id = 6 ,Type = "Quad",ResidentNo = 4, BedNo = 4, BedType = "single bed"},
                    new Room {Id = 7 ,Type = "Quad",ResidentNo = 4, BedNo = 2, BedType = "double bed"},
                    new Room {Id = 8 ,Type = "Queen",ResidentNo = 2, BedNo = 2, BedType = "Queen bed"},

                };



            builder.HasData(Rooms);
        }
    }
}
