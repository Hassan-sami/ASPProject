using Booking.Models.Data;

namespace Booking.Models.Repo
{
    public interface ICityRepo : IRepository<City>
    {
        public City GetCity(int cityId);
        public City GetCity(string name);
        public List<City> GetCities();

        public List<City> GetCitiesWithCountries();

        public List<City> TopCitiesWithCountry();

        public List<City> TopCitiesWithCountryAndHotels();
        public List<City> GetCitiesWithCountryAndHotels();
    }
}
