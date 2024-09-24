using Booking.Models;
using Booking.Models.Data;
using Booking.Models.Repo;
using Booking.viewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Booking.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<User> _repo;
        private readonly ICityRepo _cityRepo;
        private readonly IHotelRepo _hotelRepo;
        private readonly UserManager<User> _manager;
        private readonly AppDbContext _context;

        public HomeController(IRepository<User> repo, ICityRepo cityRepo,IHotelRepo hotelRepo,UserManager<User> manager,AppDbContext context)
        {
            _repo = repo;
            this._cityRepo = cityRepo;
            this._hotelRepo = hotelRepo;
            this._manager = manager;
            this._context = context;
        }
        public async Task<IActionResult> Index()
        {
            IndexViewModel indexViewModel = new IndexViewModel();
            indexViewModel.Cities = _cityRepo.GetCitiesWithCountries();
            indexViewModel.TopCities = _cityRepo.TopCitiesWithCountry();
            Random rnd = new Random();
            indexViewModel.Hotels = _context.Hotels.Where(hotel => hotel.StarsNo == 5).Include(hotel => hotel.City).Take(8).ToList();
            if (User.Identity.IsAuthenticated)
            {
                indexViewModel.User = await _manager.FindByNameAsync(User.Identity.Name);
            }
            return View(indexViewModel);
        }

        [HttpGet]
        public async  Task<IActionResult> GetCityHotels(int cityId)
        {
            HotelViewModel hotelView = new HotelViewModel();
            hotelView.Hotels =  _hotelRepo.Filter(hotel => hotel.CityId == cityId);
            hotelView.City = _cityRepo.GetCity(cityId);
            if (User.Identity.IsAuthenticated)
            {
                hotelView.User = await _manager.FindByNameAsync(User.Identity.Name);
            }
            return View(hotelView);
        }

        public async Task<IActionResult> ContactUs()
        {
            var user = await _manager.FindByNameAsync(User.Identity.Name);
        
            return View("Privacy",user);
        }

        
    }
}