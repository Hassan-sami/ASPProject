using Booking.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json.Linq;

namespace Booking.Models.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries");
            Country[] countries =
            {
                new Country { Id = 1 ,Name = "France", Continent = "Europe"},
                new Country { Id = 2 ,Name = "England", Continent = "Europe"},
                new Country { Id = 3 ,Name = "Italy", Continent = "Europe"},
                new Country { Id = 4 ,Name = "Spain", Continent = "Europe"},
                new Country { Id = 5 ,Name = "netherlands", Continent = "Europe"},
                new Country { Id = 6 ,Name = "Switzerland", Continent = "Europe"},
                new Country { Id = 7 ,Name = "Portogal", Continent = "Europe"},
                new Country { Id = 8 ,Name = "Sweden", Continent = "Europe"},
                new Country { Id = 9 ,Name = "Austria", Continent = "Europe"},
                new Country { Id = 10 ,Name = "Germany", Continent = "Europe"},
                new Country { Id = 11 ,Name = "Greece", Continent = "Europe"},
                new Country { Id = 12 ,Name = "Türkiye", Continent = "Europe"},
               

            };
            builder.HasData(countries);

        }
    }
}
