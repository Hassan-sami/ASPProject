using Booking.Models.Configuration;
using Booking.Models.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;

namespace Booking.Models
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<UserTrip> UserTrips { get; set; }

        //public DbSet<OneWayTrip> OneWay {get; set;}

        //public DbSet<RoundTrip> Round { get; set; }

        public DbSet<Trip> Trips { get; set; }

        public DbSet<BookedRoom> BookedRooms { get; set; }

        public DbSet<HotelRoom> HotelRooms { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(TripConfiguration)));


            base.OnModelCreating(builder);
        }

    }
}
