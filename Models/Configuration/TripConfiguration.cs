using Booking.Models.Data;
using Booking.Models.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Models.Configuration
{
    public class TripConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.ToTable("Trips");



            builder.HasMany<User>(trip => trip.Users)
               .WithMany(user => user.Trips).UsingEntity<UserTrip>();


            Trip[] Trips =
            {
                new Trip {Id = 1, From = "Paris", To = "London",IsRoundTrip = false , MaxNumberOfPassenger = 342, PricePerAdult = 50m, PricePerChild = 40m },
                new Trip {Id = 2, From = "Paris", To = "Bern",IsRoundTrip = false , MaxNumberOfPassenger = 362, PricePerAdult = 80m, PricePerChild = 70m },
                new Trip {Id = 3, From = "Paris", To = "Berlin",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 75m, PricePerChild = 70m },
                new Trip {Id = 4, From = "Paris", To = "Athens",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 85m, PricePerChild = 77m },
                new Trip {Id = 5, From = "Paris", To = "Amsterdam",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 85m, PricePerChild = 77m },
                new Trip {Id = 6, From = "Paris", To = "Vienna",IsRoundTrip = false , MaxNumberOfPassenger = 342, PricePerAdult = 50m, PricePerChild = 40m },
                new Trip {Id = 7, From = "Paris", To = "Venice",IsRoundTrip = false , MaxNumberOfPassenger = 362, PricePerAdult = 80m, PricePerChild = 70m },
                new Trip {Id = 8, From = "Paris", To = "Stockholm",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 75m, PricePerChild = 70m },
                new Trip {Id = 9, From = "Paris", To = "Rome",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 85m, PricePerChild = 77m },
                new Trip {Id = 10, From = "Paris", To = "LiverPool",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 85m, PricePerChild = 77m },
                new Trip {Id = 11, From = "Paris", To = "Lisbon",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 85m, PricePerChild = 77m },


                new Trip {Id = 12, From = "London", To = "Paris",IsRoundTrip = false , MaxNumberOfPassenger = 342, PricePerAdult = 52m, PricePerChild = 45m},
                new Trip {Id = 13, From = "London", To = "Bern",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 60m, PricePerChild = 49m},
                new Trip {Id = 14, From = "London", To = "Berlin",IsRoundTrip = false , MaxNumberOfPassenger = 368, PricePerAdult = 76m, PricePerChild = 70m},
                new Trip {Id = 15, From = "London", To = "Athens",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 80m, PricePerChild = 70m},
                new Trip {Id = 16, From = "London", To = "Amsterdam",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 80m, PricePerChild = 70m},
                new Trip {Id = 17, From = "London", To = "Vienna",IsRoundTrip = false , MaxNumberOfPassenger = 342, PricePerAdult = 52m, PricePerChild = 45m},
                new Trip {Id = 18, From = "London", To = "Venice",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 60m, PricePerChild = 49m},
                new Trip {Id = 19, From = "London", To = "Stockholm",IsRoundTrip = false , MaxNumberOfPassenger = 368, PricePerAdult = 76m, PricePerChild = 70m},
                new Trip {Id = 20, From = "London", To = "Rome",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 80m, PricePerChild = 70m},
                new Trip {Id = 21, From = "London", To = "LiverPool",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 80m, PricePerChild = 70m},
                new Trip {Id = 22, From = "London", To = "Lisbon",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 80m, PricePerChild = 70m},

                new Trip {Id = 23, From = "Bern", To = "Paris",IsRoundTrip = false , MaxNumberOfPassenger = 376, PricePerAdult = 80m, PricePerChild = 70m},
                new Trip {Id = 24, From = "Bern", To = "London",IsRoundTrip = false , MaxNumberOfPassenger = 356, PricePerAdult = 86m, PricePerChild = 79m},
                new Trip {Id = 25, From = "Bern", To = "Berlin",IsRoundTrip = false , MaxNumberOfPassenger = 366, PricePerAdult = 66m, PricePerChild = 66m},
                new Trip {Id = 26, From = "Bern", To = "Athens",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 53m, PricePerChild = 53m},
                new Trip {Id = 27, From = "Bern", To = "Amsterdam",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 60m, PricePerChild = 53m},
                new Trip {Id = 28, From = "Bern", To = "Vienna",IsRoundTrip = false , MaxNumberOfPassenger = 376, PricePerAdult = 80m, PricePerChild = 70m},
                new Trip {Id = 29, From = "Bern", To = "Venice",IsRoundTrip = false , MaxNumberOfPassenger = 356, PricePerAdult = 86m, PricePerChild = 79m},
                new Trip {Id = 30, From = "Bern", To = "Stockholm",IsRoundTrip = false , MaxNumberOfPassenger = 366, PricePerAdult = 66m, PricePerChild = 66m},
                new Trip {Id = 31, From = "Bern", To = "Rome",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 53m, PricePerChild = 53m},
                new Trip {Id = 32, From = "Bern", To = "LiverPool",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 60m, PricePerChild = 53m},
                new Trip {Id = 33, From = "Bern", To = "Lisbon",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 60m, PricePerChild = 53m},




                new Trip {Id = 34, From = "Berlin", To = "Paris",IsRoundTrip = false , MaxNumberOfPassenger = 376, PricePerAdult = 84m, PricePerChild = 72m},
                new Trip {Id = 35, From = "Berlin", To = "London",IsRoundTrip = false , MaxNumberOfPassenger = 356, PricePerAdult = 83m, PricePerChild = 79m},
                new Trip {Id =36, From = "Berlin", To = "Bern",IsRoundTrip = false , MaxNumberOfPassenger = 366, PricePerAdult = 67m, PricePerChild = 66m},
                new Trip {Id = 37, From = "Berlin", To = "Athens",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 58m, PricePerChild = 53m},
                new Trip {Id = 38, From = "Berlin", To = "Amsterdam",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 64m, PricePerChild = 53m},
                new Trip {Id = 39, From = "Berlin", To = "Vienna",IsRoundTrip = false , MaxNumberOfPassenger = 376, PricePerAdult = 84m, PricePerChild = 72m},
                new Trip {Id = 40, From = "Berlin", To = "Venice",IsRoundTrip = false , MaxNumberOfPassenger = 356, PricePerAdult = 83m, PricePerChild = 79m},
                new Trip {Id =41, From = "Berlin", To = "Stockholm",IsRoundTrip = false , MaxNumberOfPassenger = 366, PricePerAdult = 67m, PricePerChild = 66m},
                new Trip {Id = 42, From = "Berlin", To = "Rome",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 58m, PricePerChild = 53m},
                new Trip {Id = 43, From = "Berlin", To = "LiverPool",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 64m, PricePerChild = 53m},
                new Trip {Id = 44, From = "Berlin", To = "Lisbon",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 64m, PricePerChild = 53m},


                new Trip {Id = 45, From = "Athens", To = "Paris",IsRoundTrip = false , MaxNumberOfPassenger = 356, PricePerAdult = 84m, PricePerChild = 72m},
                new Trip {Id = 46, From = "Athens", To = "London",IsRoundTrip = false , MaxNumberOfPassenger = 376, PricePerAdult = 83m, PricePerChild = 79m},
                new Trip {Id = 47, From = "Athens", To = "Bern",IsRoundTrip = false , MaxNumberOfPassenger = 387, PricePerAdult = 67m, PricePerChild = 66m},
                new Trip {Id = 48, From = "Athens", To = "Berlin",IsRoundTrip = false , MaxNumberOfPassenger = 390, PricePerAdult = 58m, PricePerChild = 53m},
                new Trip {Id = 49, From = "Athens", To = "Amsterdam",IsRoundTrip = false , MaxNumberOfPassenger = 298, PricePerAdult = 64m, PricePerChild = 53m},
                new Trip {Id = 50, From = "Athens", To = "Vienna",IsRoundTrip = false , MaxNumberOfPassenger = 356, PricePerAdult = 84m, PricePerChild = 72m},
                new Trip {Id = 51, From = "Athens", To = "Venice",IsRoundTrip = false , MaxNumberOfPassenger = 376, PricePerAdult = 83m, PricePerChild = 79m},
                new Trip {Id = 52, From = "Athens", To = "Stockholm",IsRoundTrip = false , MaxNumberOfPassenger = 387, PricePerAdult = 67m, PricePerChild = 66m},
                new Trip {Id = 53, From = "Athens", To = "Rome",IsRoundTrip = false , MaxNumberOfPassenger = 390, PricePerAdult = 58m, PricePerChild = 53m},
                new Trip {Id = 54, From = "Athens", To = "LiverPool",IsRoundTrip = false , MaxNumberOfPassenger = 298, PricePerAdult = 64m, PricePerChild = 53m},
                new Trip {Id = 55, From = "Athens", To = "Lisbon",IsRoundTrip = false , MaxNumberOfPassenger = 298, PricePerAdult = 64m, PricePerChild = 53m},


                new Trip {Id = 56, From = "Amsterdam", To = "Paris",IsRoundTrip = false , MaxNumberOfPassenger = 346, PricePerAdult = 86m, PricePerChild = 74m},
                new Trip {Id = 57, From = "Amsterdam", To = "London",IsRoundTrip = false , MaxNumberOfPassenger = 366, PricePerAdult = 88m, PricePerChild = 75m},
                new Trip {Id = 58, From = "Amsterdam", To = "Bern",IsRoundTrip = false , MaxNumberOfPassenger = 377, PricePerAdult = 66m, PricePerChild = 66m},
                new Trip {Id = 59, From = "Amsterdam", To = "Berlin",IsRoundTrip = false , MaxNumberOfPassenger = 398, PricePerAdult = 60m, PricePerChild = 56m},
                new Trip {Id = 60, From = "Amsterdam", To = "Athens",IsRoundTrip = false , MaxNumberOfPassenger = 310, PricePerAdult = 59m, PricePerChild = 57m},
                new Trip {Id = 61, From = "Amsterdam", To = "Vienna",IsRoundTrip = false , MaxNumberOfPassenger = 346, PricePerAdult = 86m, PricePerChild = 74m},
                new Trip {Id = 62, From = "Amsterdam", To = "Venice",IsRoundTrip = false , MaxNumberOfPassenger = 346, PricePerAdult = 86m, PricePerChild = 74m},
                new Trip {Id = 63, From = "Amsterdam", To = "Stockholm",IsRoundTrip = false , MaxNumberOfPassenger = 366, PricePerAdult = 88m, PricePerChild = 75m},
                new Trip {Id = 64, From = "Amsterdam", To = "Rome",IsRoundTrip = false , MaxNumberOfPassenger = 377, PricePerAdult = 66m, PricePerChild = 66m},
                new Trip {Id = 65, From = "Amsterdam", To = "LiverPool",IsRoundTrip = false , MaxNumberOfPassenger = 398, PricePerAdult = 60m, PricePerChild = 56m},
                new Trip {Id = 66, From = "Amsterdam", To = "Lisbon",IsRoundTrip = false , MaxNumberOfPassenger = 310, PricePerAdult = 59m, PricePerChild = 57m},

                new Trip {Id = 67, From = "Vienna", To = "London",IsRoundTrip = false , MaxNumberOfPassenger = 342, PricePerAdult = 50m, PricePerChild = 40m },
                new Trip {Id = 68, From = "Vienna", To = "Bern",IsRoundTrip = false , MaxNumberOfPassenger = 362, PricePerAdult = 80m, PricePerChild = 70m },
                new Trip {Id = 69, From = "Vienna", To = "Berlin",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 75m, PricePerChild = 70m },
                new Trip {Id = 70, From = "Vienna", To = "Athens",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 85m, PricePerChild = 77m },
                new Trip {Id = 71, From = "Vienna", To = "Amsterdam",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 85m, PricePerChild = 77m },
                new Trip {Id = 72, From = "Vienna", To = "Paris",IsRoundTrip = false , MaxNumberOfPassenger = 342, PricePerAdult = 50m, PricePerChild = 40m },
                new Trip {Id = 73, From = "Vienna", To = "Venice",IsRoundTrip = false , MaxNumberOfPassenger = 362, PricePerAdult = 80m, PricePerChild = 70m },
                new Trip {Id = 74, From = "Vienna", To = "Stockholm",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 75m, PricePerChild = 70m },
                new Trip {Id = 75, From = "Vienna", To = "Rome",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 85m, PricePerChild = 77m },
                new Trip {Id = 76, From = "Vienna", To = "LiverPool",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 85m, PricePerChild = 77m },
                new Trip {Id = 77, From = "Vienna", To = "Lisbon",IsRoundTrip = false , MaxNumberOfPassenger = 352, PricePerAdult = 85m, PricePerChild = 77m },

                new Trip {Id = 78, From = "Venice", To = "Paris",IsRoundTrip = false , MaxNumberOfPassenger = 342, PricePerAdult = 52m, PricePerChild = 45m},
                new Trip {Id = 79, From = "Venice", To = "Bern",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 60m, PricePerChild = 49m},
                new Trip {Id = 80, From = "Venice", To = "Berlin",IsRoundTrip = false , MaxNumberOfPassenger = 368, PricePerAdult = 76m, PricePerChild = 70m},
                new Trip {Id = 81, From = "Venice", To = "Athens",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 80m, PricePerChild = 70m},
                new Trip {Id = 82, From = "Venice", To = "Amsterdam",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 80m, PricePerChild = 70m},
                new Trip {Id = 83, From = "Venice", To = "Vienna",IsRoundTrip = false , MaxNumberOfPassenger = 342, PricePerAdult = 52m, PricePerChild = 45m},
                new Trip {Id = 84, From = "Venice", To = "London",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 60m, PricePerChild = 49m},
                new Trip {Id = 85, From = "Venice", To = "Stockholm",IsRoundTrip = false , MaxNumberOfPassenger = 368, PricePerAdult = 76m, PricePerChild = 70m},
                new Trip {Id = 86, From = "Venice", To = "Rome",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 80m, PricePerChild = 70m},
                new Trip {Id = 87, From = "Venice", To = "LiverPool",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 80m, PricePerChild = 70m},
                new Trip {Id = 88, From = "Venice", To = "Lisbon",IsRoundTrip = false , MaxNumberOfPassenger = 378, PricePerAdult = 80m, PricePerChild = 70m},

                new Trip {Id = 89, From = "Stockholm", To = "Paris",IsRoundTrip = false , MaxNumberOfPassenger = 376, PricePerAdult = 80m, PricePerChild = 70m},
                new Trip {Id = 90, From = "Stockholm", To = "London",IsRoundTrip = false , MaxNumberOfPassenger = 356, PricePerAdult = 86m, PricePerChild = 79m},
                new Trip {Id = 91, From = "Stockholm", To = "Berlin",IsRoundTrip = false , MaxNumberOfPassenger = 366, PricePerAdult = 66m, PricePerChild = 66m},
                new Trip {Id = 92, From = "Stockholm", To = "Athens",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 53m, PricePerChild = 53m},
                new Trip {Id = 93, From = "Stockholm", To = "Amsterdam",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 60m, PricePerChild = 53m},
                new Trip {Id = 94, From = "Stockholm", To = "Vienna",IsRoundTrip = false , MaxNumberOfPassenger = 376, PricePerAdult = 80m, PricePerChild = 70m},
                new Trip {Id = 95, From = "Stockholm", To = "Venice",IsRoundTrip = false , MaxNumberOfPassenger = 356, PricePerAdult = 86m, PricePerChild = 79m},
                new Trip {Id = 96, From = "Stockholm", To = "Bern",IsRoundTrip = false , MaxNumberOfPassenger = 366, PricePerAdult = 66m, PricePerChild = 66m},
                new Trip {Id = 97, From = "Stockholm", To = "Rome",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 53m, PricePerChild = 53m},
                new Trip {Id = 98, From = "Stockholm", To = "LiverPool",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 60m, PricePerChild = 53m},
                new Trip {Id = 99, From = "Stockholm", To = "Lisbon",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 60m, PricePerChild = 53m},

                new Trip {Id = 100, From = "Rome", To = "Paris",IsRoundTrip = false , MaxNumberOfPassenger = 376, PricePerAdult = 84m, PricePerChild = 72m},
                new Trip {Id = 101, From = "Rome", To = "London",IsRoundTrip = false , MaxNumberOfPassenger = 356, PricePerAdult = 83m, PricePerChild = 79m},
                new Trip {Id =102, From = "Rome", To = "Bern",IsRoundTrip = false , MaxNumberOfPassenger = 366, PricePerAdult = 67m, PricePerChild = 66m},
                new Trip {Id = 103, From = "Rome", To = "Athens",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 58m, PricePerChild = 53m},
                new Trip {Id = 104, From = "Rome", To = "Amsterdam",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 64m, PricePerChild = 53m},
                new Trip {Id = 105, From = "Rome", To = "Vienna",IsRoundTrip = false , MaxNumberOfPassenger = 376, PricePerAdult = 84m, PricePerChild = 72m},
                new Trip {Id = 106, From = "Rome", To = "Venice",IsRoundTrip = false , MaxNumberOfPassenger = 356, PricePerAdult = 83m, PricePerChild = 79m},
                new Trip {Id =107, From = "Rome", To = "Stockholm",IsRoundTrip = false , MaxNumberOfPassenger = 366, PricePerAdult = 67m, PricePerChild = 66m},
                new Trip {Id = 108, From = "Rome", To = "Berlin",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 58m, PricePerChild = 53m},
                new Trip {Id = 109, From = "Rome", To = "LiverPool",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 64m, PricePerChild = 53m},
                new Trip {Id = 110, From = "Rome", To = "Lisbon",IsRoundTrip = false , MaxNumberOfPassenger = 353, PricePerAdult = 64m, PricePerChild = 53m},


                new Trip {Id = 111, From = "LiverPool", To = "Paris",IsRoundTrip = false , MaxNumberOfPassenger = 356, PricePerAdult = 84m, PricePerChild = 72m},
                new Trip {Id = 112, From = "LiverPool", To = "London",IsRoundTrip = false , MaxNumberOfPassenger = 376, PricePerAdult = 83m, PricePerChild = 79m},
                new Trip {Id = 113, From = "LiverPool", To = "Bern",IsRoundTrip = false , MaxNumberOfPassenger = 387, PricePerAdult = 67m, PricePerChild = 66m},
                new Trip {Id = 114, From = "LiverPool", To = "Berlin",IsRoundTrip = false , MaxNumberOfPassenger = 390, PricePerAdult = 58m, PricePerChild = 53m},
                new Trip {Id = 115, From = "LiverPool", To = "Amsterdam",IsRoundTrip = false , MaxNumberOfPassenger = 298, PricePerAdult = 64m, PricePerChild = 53m},
                new Trip {Id = 116, From = "LiverPool", To = "Vienna",IsRoundTrip = false , MaxNumberOfPassenger = 356, PricePerAdult = 84m, PricePerChild = 72m},
                new Trip {Id = 117, From = "LiverPool", To = "Venice",IsRoundTrip = false , MaxNumberOfPassenger = 376, PricePerAdult = 83m, PricePerChild = 79m},
                new Trip {Id = 118, From = "LiverPool", To = "Stockholm",IsRoundTrip = false , MaxNumberOfPassenger = 387, PricePerAdult = 67m, PricePerChild = 66m},
                new Trip {Id = 119, From = "LiverPool", To = "Rome",IsRoundTrip = false , MaxNumberOfPassenger = 390, PricePerAdult = 58m, PricePerChild = 53m},
                new Trip {Id = 120, From = "LiverPool", To = "Athens",IsRoundTrip = false , MaxNumberOfPassenger = 298, PricePerAdult = 64m, PricePerChild = 53m},
                new Trip {Id = 121, From = "LiverPool", To = "Lisbon",IsRoundTrip = false , MaxNumberOfPassenger = 298, PricePerAdult = 64m, PricePerChild = 53m},


                new Trip {Id = 122, From = "Lisbon", To = "Paris",IsRoundTrip = false , MaxNumberOfPassenger = 346, PricePerAdult = 86m, PricePerChild = 74m},
                new Trip {Id = 123, From = "Lisbon", To = "London",IsRoundTrip = false , MaxNumberOfPassenger = 366, PricePerAdult = 88m, PricePerChild = 75m},
                new Trip {Id = 124, From = "Lisbon", To = "Bern",IsRoundTrip = false , MaxNumberOfPassenger = 377, PricePerAdult = 66m, PricePerChild = 66m},
                new Trip {Id = 125, From = "Lisbon", To = "Berlin",IsRoundTrip = false , MaxNumberOfPassenger = 398, PricePerAdult = 60m, PricePerChild = 56m},
                new Trip {Id = 126, From = "Lisbon", To = "Athens",IsRoundTrip = false , MaxNumberOfPassenger = 310, PricePerAdult = 59m, PricePerChild = 57m},
                new Trip {Id = 127, From = "Lisbon", To = "Vienna",IsRoundTrip = false , MaxNumberOfPassenger = 346, PricePerAdult = 86m, PricePerChild = 74m},
                new Trip {Id = 128, From = "Lisbon", To = "Venice",IsRoundTrip = false , MaxNumberOfPassenger = 346, PricePerAdult = 86m, PricePerChild = 74m},
                new Trip {Id = 129, From = "Lisbon", To = "Stockholm",IsRoundTrip = false , MaxNumberOfPassenger = 366, PricePerAdult = 88m, PricePerChild = 75m},
                new Trip {Id = 130, From = "Lisbon", To = "Rome",IsRoundTrip = false , MaxNumberOfPassenger = 377, PricePerAdult = 66m, PricePerChild = 66m},
                new Trip {Id = 131, From = "Lisbon", To = "LiverPool",IsRoundTrip = false , MaxNumberOfPassenger = 398, PricePerAdult = 60m, PricePerChild = 56m},
                new Trip {Id = 132, From = "Lisbon", To = "Amsterdam",IsRoundTrip = false , MaxNumberOfPassenger = 310, PricePerAdult = 59m, PricePerChild = 57m},















                new Trip {Id = 133, From = "Paris", To = "London",IsRoundTrip = true , MaxNumberOfPassenger = 342, PricePerAdult = 110m, PricePerChild = 90m },
                new Trip {Id = 134, From = "Paris", To = "Bern",IsRoundTrip = true , MaxNumberOfPassenger = 362, PricePerAdult = 190m, PricePerChild = 170m },
                new Trip {Id = 135, From = "Paris", To = "Berlin",IsRoundTrip = true , MaxNumberOfPassenger = 352, PricePerAdult = 180m, PricePerChild = 160m },
                new Trip {Id = 136, From = "Paris", To = "Athens",IsRoundTrip = true , MaxNumberOfPassenger = 352, PricePerAdult = 185m, PricePerChild = 166m },
                new Trip {Id = 137, From = "Paris", To = "Amsterdam",IsRoundTrip = true , MaxNumberOfPassenger = 352, PricePerAdult = 186m, PricePerChild = 170m },
                new Trip {Id = 138, From = "Paris", To = "Vienna",IsRoundTrip = true , MaxNumberOfPassenger = 342, PricePerAdult = 110m, PricePerChild = 90m },
                new Trip {Id = 139, From = "Paris", To = "Venice",IsRoundTrip = true , MaxNumberOfPassenger = 342, PricePerAdult = 110m, PricePerChild = 90m },
                new Trip {Id = 140, From = "Paris", To = "Stockholm",IsRoundTrip = true , MaxNumberOfPassenger = 362, PricePerAdult = 190m, PricePerChild = 170m },
                new Trip {Id = 141, From = "Paris", To = "Rome",IsRoundTrip = true , MaxNumberOfPassenger = 352, PricePerAdult = 180m, PricePerChild = 160m },
                new Trip {Id = 142, From = "Paris", To = "LiverPool",IsRoundTrip = true , MaxNumberOfPassenger = 352, PricePerAdult = 185m, PricePerChild = 166m },
                new Trip {Id = 143, From = "Paris", To = "Lisbon",IsRoundTrip = true , MaxNumberOfPassenger = 352, PricePerAdult = 186m, PricePerChild = 170m },

                new Trip {Id = 144, From = "London", To = "Paris",IsRoundTrip = true , MaxNumberOfPassenger = 342, PricePerAdult = 120m, PricePerChild = 112m},
                new Trip {Id =145, From = "London", To = "Bern",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 130m, PricePerChild = 120m},
                new Trip {Id = 146, From = "London", To = "Berlin",IsRoundTrip = true , MaxNumberOfPassenger = 368, PricePerAdult = 133m, PricePerChild = 120m},
                new Trip {Id = 147, From = "London", To = "Athens",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 170m, PricePerChild = 156},
                new Trip {Id = 148, From = "London", To = "Amsterdam",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 175m, PricePerChild = 160m},
                new Trip {Id = 149, From = "London", To = "Vienna",IsRoundTrip = true , MaxNumberOfPassenger = 342, PricePerAdult = 120m, PricePerChild = 112m},
                new Trip {Id = 150, From = "London", To = "Venice",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 130m, PricePerChild = 120m},
                new Trip {Id = 151, From = "London", To = "Stockholm",IsRoundTrip = true , MaxNumberOfPassenger = 368, PricePerAdult = 133m, PricePerChild = 120m},
                new Trip {Id = 152, From = "London", To = "Rome",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 170m, PricePerChild = 156},
                new Trip {Id = 153, From = "London", To = "LiverPool",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 175m, PricePerChild = 160m},
                new Trip {Id = 154, From = "London", To = "Lisbon",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 175m, PricePerChild = 160m},


                new Trip {Id = 155, From = "Bern", To = "Paris",IsRoundTrip = true , MaxNumberOfPassenger = 376, PricePerAdult = 180m, PricePerChild = 166m},
                new Trip {Id = 156, From = "Bern", To = "London",IsRoundTrip = true , MaxNumberOfPassenger = 356, PricePerAdult = 190m, PricePerChild = 180m},
                new Trip {Id = 157, From = "Bern", To = "Berlin",IsRoundTrip = true , MaxNumberOfPassenger = 366, PricePerAdult = 175m, PricePerChild = 160m},
                new Trip {Id = 158, From = "Bern", To = "Athens",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 115m, PricePerChild = 100m},
                new Trip {Id = 159, From = "Bern", To = "Amsterdam",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 135m, PricePerChild = 110m},
                new Trip {Id = 160, From = "Bern", To = "Vienna",IsRoundTrip = true , MaxNumberOfPassenger = 376, PricePerAdult = 180m, PricePerChild = 166m},
                new Trip {Id = 161, From = "Bern", To = "Venice",IsRoundTrip = true , MaxNumberOfPassenger = 356, PricePerAdult = 190m, PricePerChild = 180m},
                new Trip {Id = 162, From = "Bern", To = "Stockholm",IsRoundTrip = true , MaxNumberOfPassenger = 366, PricePerAdult = 175m, PricePerChild = 160m},
                new Trip {Id = 163, From = "Bern", To = "Rome",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 115m, PricePerChild = 100m},
                new Trip {Id = 164, From = "Bern", To = "LiverPool",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 135m, PricePerChild = 110m},
                new Trip {Id = 165, From = "Bern", To = "Lisbon",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 135m, PricePerChild = 110m},



                new Trip {Id = 166, From = "Berlin", To = "Paris",IsRoundTrip = true , MaxNumberOfPassenger = 376, PricePerAdult = 170m, PricePerChild = 160m},
                new Trip {Id = 167, From = "Berlin", To = "London",IsRoundTrip = true , MaxNumberOfPassenger = 356, PricePerAdult = 173m, PricePerChild = 160m},
                new Trip {Id = 168, From = "Berlin", To = "Bern",IsRoundTrip = true , MaxNumberOfPassenger = 366, PricePerAdult = 156m, PricePerChild = 130m},
                new Trip {Id = 169, From = "Berlin", To = "Athens",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 130m, PricePerChild = 120m},
                new Trip {Id = 170, From = "Berlin", To = "Amsterdam",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 123m, PricePerChild = 113m},
                new Trip {Id = 171, From = "Berlin", To = "Vienna",IsRoundTrip = true , MaxNumberOfPassenger = 376, PricePerAdult = 170m, PricePerChild = 160m},
                new Trip {Id = 172, From = "Berlin", To = "Venice",IsRoundTrip = true , MaxNumberOfPassenger = 356, PricePerAdult = 173m, PricePerChild = 160m},
                new Trip {Id = 173, From = "Berlin", To = "Stockholm",IsRoundTrip = true , MaxNumberOfPassenger = 366, PricePerAdult = 156m, PricePerChild = 130m},
                new Trip {Id = 174, From = "Berlin", To = "Rome",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 130m, PricePerChild = 120m},
                new Trip {Id = 175, From = "Berlin", To = "LiverPool",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 123m, PricePerChild = 113m},
                new Trip {Id = 176, From = "Berlin", To = "Lisbon",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 123m, PricePerChild = 113m},

                new Trip {Id = 177, From = "Athens", To = "Paris",IsRoundTrip = true , MaxNumberOfPassenger = 356, PricePerAdult = 176m, PricePerChild = 164m},
                new Trip {Id = 178, From = "Athens", To = "London",IsRoundTrip = true , MaxNumberOfPassenger = 376, PricePerAdult = 189m, PricePerChild = 170m},
                new Trip {Id = 179, From = "Athens", To = "Bern",IsRoundTrip = true , MaxNumberOfPassenger = 387, PricePerAdult = 190m, PricePerChild = 170m},
                new Trip {Id = 180, From = "Athens", To = "Berlin",IsRoundTrip = true , MaxNumberOfPassenger = 390, PricePerAdult = 150m, PricePerChild = 140m},
                new Trip {Id = 181, From = "Athens", To = "Amsterdam",IsRoundTrip = true , MaxNumberOfPassenger = 298, PricePerAdult = 140m, PricePerChild = 130m},
                new Trip {Id = 182, From = "Athens", To = "Vienna",IsRoundTrip = true , MaxNumberOfPassenger = 356, PricePerAdult = 176m, PricePerChild = 164m},
                new Trip {Id = 183, From = "Athens", To = "Venice",IsRoundTrip = true , MaxNumberOfPassenger = 376, PricePerAdult = 189m, PricePerChild = 170m},
                new Trip {Id = 184, From = "Athens", To = "Stockholm",IsRoundTrip = true , MaxNumberOfPassenger = 387, PricePerAdult = 190m, PricePerChild = 170m},
                new Trip {Id = 185, From = "Athens", To = "Rome",IsRoundTrip = true , MaxNumberOfPassenger = 390, PricePerAdult = 150m, PricePerChild = 140m},
                new Trip {Id = 186, From = "Athens", To = "LiverPool",IsRoundTrip = true , MaxNumberOfPassenger = 298, PricePerAdult = 140m, PricePerChild = 130m},
                new Trip {Id = 187, From = "Athens", To = "Lisbon",IsRoundTrip = true , MaxNumberOfPassenger = 298, PricePerAdult = 140m, PricePerChild = 130m},


                new Trip {Id = 188, From = "Amsterdam", To = "Paris",IsRoundTrip = true , MaxNumberOfPassenger = 346, PricePerAdult = 180m, PricePerChild = 170m},
                new Trip {Id = 189, From = "Amsterdam", To = "London",IsRoundTrip = true , MaxNumberOfPassenger = 366, PricePerAdult = 200m, PricePerChild = 170m},
                new Trip {Id = 190, From = "Amsterdam", To = "Bern",IsRoundTrip = true , MaxNumberOfPassenger = 377, PricePerAdult = 180m, PricePerChild = 170m},
                new Trip {Id = 191, From = "Amsterdam", To = "Berlin",IsRoundTrip = true , MaxNumberOfPassenger = 398, PricePerAdult = 155m, PricePerChild = 135m},
                new Trip {Id = 192, From = "Amsterdam", To = "Athens",IsRoundTrip = true , MaxNumberOfPassenger = 310, PricePerAdult = 150m, PricePerChild = 130m},
                new Trip {Id = 193, From = "Amsterdam", To = "Vienna",IsRoundTrip = true , MaxNumberOfPassenger = 346, PricePerAdult = 180m, PricePerChild = 170m},
                new Trip {Id = 194, From = "Amsterdam", To = "Venice",IsRoundTrip = true , MaxNumberOfPassenger = 366, PricePerAdult = 200m, PricePerChild = 170m},
                new Trip {Id = 195, From = "Amsterdam", To = "Stockholm",IsRoundTrip = true , MaxNumberOfPassenger = 377, PricePerAdult = 180m, PricePerChild = 170m},
                new Trip {Id = 196, From = "Amsterdam", To = "Rome",IsRoundTrip = true , MaxNumberOfPassenger = 398, PricePerAdult = 155m, PricePerChild = 135m},
                new Trip {Id = 197, From = "Amsterdam", To = "LiverPool",IsRoundTrip = true , MaxNumberOfPassenger = 310, PricePerAdult = 150m, PricePerChild = 130m},
                new Trip {Id = 198, From = "Amsterdam", To = "Lisbon",IsRoundTrip = true , MaxNumberOfPassenger = 310, PricePerAdult = 150m, PricePerChild = 130m},

                new Trip {Id = 199, From = "Vienna", To = "London",IsRoundTrip = true , MaxNumberOfPassenger = 342, PricePerAdult = 110m, PricePerChild = 90m },
                new Trip {Id = 200, From = "Vienna", To = "Bern",IsRoundTrip = true , MaxNumberOfPassenger = 362, PricePerAdult = 190m, PricePerChild = 170m },
                new Trip {Id = 201, From = "Vienna", To = "Berlin",IsRoundTrip = true , MaxNumberOfPassenger = 352, PricePerAdult = 180m, PricePerChild = 160m },
                new Trip {Id = 202, From = "Vienna", To = "Athens",IsRoundTrip = true , MaxNumberOfPassenger = 352, PricePerAdult = 185m, PricePerChild = 166m },
                new Trip {Id = 203, From = "Vienna", To = "Amsterdam",IsRoundTrip = true , MaxNumberOfPassenger = 352, PricePerAdult = 186m, PricePerChild = 170m },
                new Trip {Id = 204, From = "Vienna", To = "Paris",IsRoundTrip = true , MaxNumberOfPassenger = 342, PricePerAdult = 110m, PricePerChild = 90m },
                new Trip {Id = 205, From = "Vienna", To = "Venice",IsRoundTrip = true , MaxNumberOfPassenger = 342, PricePerAdult = 110m, PricePerChild = 90m },
                new Trip {Id = 206, From = "Vienna", To = "Stockholm",IsRoundTrip = true , MaxNumberOfPassenger = 362, PricePerAdult = 190m, PricePerChild = 170m },
                new Trip {Id = 207, From = "Vienna", To = "Rome",IsRoundTrip = true , MaxNumberOfPassenger = 352, PricePerAdult = 180m, PricePerChild = 160m },
                new Trip {Id = 208, From = "Vienna", To = "LiverPool",IsRoundTrip = true , MaxNumberOfPassenger = 352, PricePerAdult = 185m, PricePerChild = 166m },
                new Trip {Id = 209, From = "Vienna", To = "Lisbon",IsRoundTrip = true , MaxNumberOfPassenger = 352, PricePerAdult = 186m, PricePerChild = 170m },

                new Trip {Id = 210, From = "Venice", To = "Paris",IsRoundTrip = true , MaxNumberOfPassenger = 342, PricePerAdult = 120m, PricePerChild = 112m},
                new Trip {Id =211, From = "Venice", To = "Bern",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 130m, PricePerChild = 120m},
                new Trip {Id = 212, From = "Venice", To = "Berlin",IsRoundTrip = true , MaxNumberOfPassenger = 368, PricePerAdult = 133m, PricePerChild = 120m},
                new Trip {Id = 213, From = "Venice", To = "Athens",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 170m, PricePerChild = 156},
                new Trip {Id = 214, From = "Venice", To = "Amsterdam",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 175m, PricePerChild = 160m},
                new Trip {Id = 215, From = "Venice", To = "Vienna",IsRoundTrip = true , MaxNumberOfPassenger = 342, PricePerAdult = 120m, PricePerChild = 112m},
                new Trip {Id = 216, From = "Venice", To = "London",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 130m, PricePerChild = 120m},
                new Trip {Id = 217, From = "Venice", To = "Stockholm",IsRoundTrip = true , MaxNumberOfPassenger = 368, PricePerAdult = 133m, PricePerChild = 120m},
                new Trip {Id = 218, From = "Venice", To = "Rome",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 170m, PricePerChild = 156},
                new Trip {Id = 219, From = "Venice", To = "LiverPool",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 175m, PricePerChild = 160m},
                new Trip {Id = 220, From = "Venice", To = "Lisbon",IsRoundTrip = true , MaxNumberOfPassenger = 378, PricePerAdult = 175m, PricePerChild = 160m},

                new Trip {Id = 221, From = "Stockholm", To = "Paris",IsRoundTrip = true , MaxNumberOfPassenger = 376, PricePerAdult = 180m, PricePerChild = 166m},
                new Trip {Id = 222, From = "Stockholm", To = "London",IsRoundTrip = true , MaxNumberOfPassenger = 356, PricePerAdult = 190m, PricePerChild = 180m},
                new Trip {Id = 223, From = "Stockholm", To = "Berlin",IsRoundTrip = true , MaxNumberOfPassenger = 366, PricePerAdult = 175m, PricePerChild = 160m},
                new Trip {Id = 224, From = "Stockholm", To = "Athens",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 115m, PricePerChild = 100m},
                new Trip {Id = 225, From = "Stockholm", To = "Amsterdam",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 135m, PricePerChild = 110m},
                new Trip {Id = 226, From = "Stockholm", To = "Vienna",IsRoundTrip = true , MaxNumberOfPassenger = 376, PricePerAdult = 180m, PricePerChild = 166m},
                new Trip {Id = 227, From = "Stockholm", To = "Venice",IsRoundTrip = true , MaxNumberOfPassenger = 356, PricePerAdult = 190m, PricePerChild = 180m},
                new Trip {Id = 228, From = "Stockholm", To = "Bern",IsRoundTrip = true , MaxNumberOfPassenger = 366, PricePerAdult = 175m, PricePerChild = 160m},
                new Trip {Id = 229, From = "Stockholm", To = "Rome",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 115m, PricePerChild = 100m},
                new Trip {Id = 230, From = "Stockholm", To = "LiverPool",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 135m, PricePerChild = 110m},
                new Trip {Id = 231, From = "Stockholm", To = "Lisbon",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 135m, PricePerChild = 110m},


                new Trip {Id = 232, From = "Rome", To = "Paris",IsRoundTrip = true , MaxNumberOfPassenger = 376, PricePerAdult = 170m, PricePerChild = 160m},
                new Trip {Id = 233, From = "Rome", To = "London",IsRoundTrip = true , MaxNumberOfPassenger = 356, PricePerAdult = 173m, PricePerChild = 160m},
                new Trip {Id = 234, From = "Rome", To = "Bern",IsRoundTrip = true , MaxNumberOfPassenger = 366, PricePerAdult = 156m, PricePerChild = 130m},
                new Trip {Id = 235, From = "Rome", To = "Athens",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 130m, PricePerChild = 120m},
                new Trip {Id = 236, From = "Rome", To = "Amsterdam",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 123m, PricePerChild = 113m},
                new Trip {Id = 237, From = "Rome", To = "Vienna",IsRoundTrip = true , MaxNumberOfPassenger = 376, PricePerAdult = 170m, PricePerChild = 160m},
                new Trip {Id = 238, From = "Rome", To = "Venice",IsRoundTrip = true , MaxNumberOfPassenger = 356, PricePerAdult = 173m, PricePerChild = 160m},
                new Trip {Id = 239, From = "Rome", To = "Stockholm",IsRoundTrip = true , MaxNumberOfPassenger = 366, PricePerAdult = 156m, PricePerChild = 130m},
                new Trip {Id = 240, From = "Rome", To = "Berlin",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 130m, PricePerChild = 120m},
                new Trip {Id = 241, From = "Rome", To = "LiverPool",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 123m, PricePerChild = 113m},
                new Trip {Id = 242, From = "Rome", To = "Lisbon",IsRoundTrip = true , MaxNumberOfPassenger = 353, PricePerAdult = 123m, PricePerChild = 113m},


                new Trip {Id = 243, From = "LiverPool", To = "Paris",IsRoundTrip = true , MaxNumberOfPassenger = 356, PricePerAdult = 176m, PricePerChild = 164m},
                new Trip {Id = 244, From = "LiverPool", To = "London",IsRoundTrip = true , MaxNumberOfPassenger = 376, PricePerAdult = 189m, PricePerChild = 170m},
                new Trip {Id = 245, From = "LiverPool", To = "Bern",IsRoundTrip = true , MaxNumberOfPassenger = 387, PricePerAdult = 190m, PricePerChild = 170m},
                new Trip {Id = 246, From = "LiverPool", To = "Berlin",IsRoundTrip = true , MaxNumberOfPassenger = 390, PricePerAdult = 150m, PricePerChild = 140m},
                new Trip {Id = 247, From = "LiverPool", To = "Amsterdam",IsRoundTrip = true , MaxNumberOfPassenger = 298, PricePerAdult = 140m, PricePerChild = 130m},
                new Trip {Id = 248, From = "LiverPool", To = "Vienna",IsRoundTrip = true , MaxNumberOfPassenger = 356, PricePerAdult = 176m, PricePerChild = 164m},
                new Trip {Id = 249, From = "LiverPool", To = "Venice",IsRoundTrip = true , MaxNumberOfPassenger = 376, PricePerAdult = 189m, PricePerChild = 170m},
                new Trip {Id = 250, From = "LiverPool", To = "Stockholm",IsRoundTrip = true , MaxNumberOfPassenger = 387, PricePerAdult = 190m, PricePerChild = 170m},
                new Trip {Id = 251, From = "LiverPool", To = "Rome",IsRoundTrip = true , MaxNumberOfPassenger = 390, PricePerAdult = 150m, PricePerChild = 140m},
                new Trip {Id = 252, From = "LiverPool", To = "Athens",IsRoundTrip = true , MaxNumberOfPassenger = 298, PricePerAdult = 140m, PricePerChild = 130m},
                new Trip {Id = 253, From = "LiverPool", To = "Lisbon",IsRoundTrip = true , MaxNumberOfPassenger = 298, PricePerAdult = 140m, PricePerChild = 130m},


                new Trip {Id = 254, From = "Lisbon", To = "Paris",IsRoundTrip = true , MaxNumberOfPassenger = 346, PricePerAdult = 180m, PricePerChild = 170m},
                new Trip {Id = 255, From = "Lisbon", To = "London",IsRoundTrip = true , MaxNumberOfPassenger = 366, PricePerAdult = 200m, PricePerChild = 170m},
                new Trip {Id = 256, From = "Lisbon", To = "Bern",IsRoundTrip = true , MaxNumberOfPassenger = 377, PricePerAdult = 180m, PricePerChild = 170m},
                new Trip {Id = 257, From = "Lisbon", To = "Berlin",IsRoundTrip = true , MaxNumberOfPassenger = 398, PricePerAdult = 155m, PricePerChild = 135m},
                new Trip {Id = 258, From = "Lisbon", To = "Athens",IsRoundTrip = true , MaxNumberOfPassenger = 310, PricePerAdult = 150m, PricePerChild = 130m},
                new Trip {Id = 259, From = "Lisbon", To = "Vienna",IsRoundTrip = true , MaxNumberOfPassenger = 346, PricePerAdult = 180m, PricePerChild = 170m},
                new Trip {Id = 260, From = "Lisbon", To = "Venice",IsRoundTrip = true , MaxNumberOfPassenger = 366, PricePerAdult = 200m, PricePerChild = 170m},
                new Trip {Id = 261, From = "Lisbon", To = "Stockholm",IsRoundTrip = true , MaxNumberOfPassenger = 377, PricePerAdult = 180m, PricePerChild = 170m},
                new Trip {Id = 262, From = "Lisbon", To = "Rome",IsRoundTrip = true , MaxNumberOfPassenger = 398, PricePerAdult = 155m, PricePerChild = 135m},
                new Trip {Id = 263, From = "Lisbon", To = "LiverPool",IsRoundTrip = true , MaxNumberOfPassenger = 310, PricePerAdult = 150m, PricePerChild = 130m},
                new Trip {Id = 264, From = "Lisbon", To = "Amsterdam",IsRoundTrip = true , MaxNumberOfPassenger = 310, PricePerAdult = 150m, PricePerChild = 130m},



            };


            builder.HasData(Trips);

        }
    }





    public class UserTripConfiguration : IEntityTypeConfiguration<UserTrip>
    {
        public void Configure(EntityTypeBuilder<UserTrip> builder)
        {
            builder.HasKey(userTrip => new { userTrip.TripId, userTrip.UserId, userTrip.DepartingDate });
        }
    }
}
