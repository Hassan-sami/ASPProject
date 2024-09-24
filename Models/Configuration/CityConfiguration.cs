using Booking.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Models.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities");
            

            builder.HasOne<Country>(city => city.Country).WithMany(country => country.Cities)
                .HasForeignKey(city => city.CountryId);

            City[] cities =
            {
                new City {Id = 1, Name = "Paris",Image = "paris.jpg",CountryId= 1,FromTopTen = true },
                new City {Id = 2, Name = "London",Image = "london.png",CountryId= 2,FromTopTen = true},
                new City {Id = 3, Name = "LiverPool",Image = "TrendingDestinations/Liverpool.png",CountryId= 2,FromTopTen = true },
                new City {Id = 4, Name = "Rome",Image = "TrendingDestinations/Rome.png",CountryId= 3 },
                new City {Id = 5, Name = "Venice",Image = "TrendingDestinations/Venice.png",CountryId= 3,FromTopTen = true },
                new City {Id = 6, Name = "Amsterdam",Image = "Amsterdam.png",CountryId= 5,FromTopTen = true },    
                new City {Id = 7, Name = "Bern",Image = "TrendingDestinations/Bern.png",CountryId= 6,FromTopTen = true },
                new City {Id = 8, Name = "Lisbon",Image = "lisbon.png",CountryId= 7 , FromTopTen = true},
                new City {Id = 9, Name = "Stockholm",Image = "TrendingDestinations/Stockholm.png",CountryId= 8 , FromTopTen = true},
                new City {Id = 10, Name = "Vienna",Image = "TrendingDestinations/london.png",CountryId= 9 , FromTopTen = true  },
                new City {Id = 11, Name = "Berlin",Image = "berlin.png",CountryId= 10 },
                new City {Id = 12, Name = "Athens",Image = "TrendingDestinations/Athens.png",CountryId= 11 , FromTopTen = true },
                
                


            };
            builder.HasData(cities);
        }
    }
}
