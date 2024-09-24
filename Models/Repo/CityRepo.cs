using Booking.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace Booking.Models.Repo
{
    public class CityRepo : Repository<City>, ICityRepo
    {
        private readonly AppDbContext _context;

        public CityRepo(AppDbContext context) : base(context)
        {
            this._context = context;
        }
        public City GetCity(int cityId)
        {
           return  _context.Cities.Include(city => city.Country).FirstOrDefault(city => city.Id == cityId);
        }

        public City GetCity(string name)
        {
            return _context.Cities.Include(city=>city.Hotels).FirstOrDefault(city => city.Name == name);
        }

        public List<City> GetCities()
        {
            return _context.Cities.ToList();
        }

        public List<City> GetCitiesWithCountries()
        {
           

            return _context.Cities.Include(City => City.Country).ToList();
        }

        public List<City> GetCitiesWithCountryAndHotels()
        {
            return _context.Cities.Include(city => city.Country).Include(city => city.Hotels).ToList();   
        }

        public List<City> TopCitiesWithCountry()
        {
            return _context.Cities.Where(city => city.FromTopTen == true).Include(City => City.Country).ToList();
        }

        public List<City> TopCitiesWithCountryAndHotels()
        {
            return _context.Cities.Where(city => city.FromTopTen == true).Include(city => city.Country).Include(city => city.Hotels).ToList();
        }
    }
}
