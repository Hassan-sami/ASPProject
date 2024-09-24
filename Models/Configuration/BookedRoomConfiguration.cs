using Booking.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Models.Configuration
{
    public class BookedRoomConfiguration : IEntityTypeConfiguration<BookedRoom>
    {
        public void Configure(EntityTypeBuilder<BookedRoom> builder)
        {
            builder.ToTable("Bookedrooms");
            
            builder.HasKey(x => x.Id);  
            
            builder.HasOne<User>(booked => booked.User)
                .WithMany(user => user.BookedRooms)
                .HasForeignKey(booked => booked.UserId);

            builder.HasOne<Room>(booked => booked.Room).WithOne()
                .HasForeignKey<BookedRoom>(booked => booked.RoomId);

            builder.HasOne<Hotel>(booked => booked.Hotel).WithOne()
                .HasForeignKey<BookedRoom>(booked => booked.HotelId);

            
            

        }
    }
}
