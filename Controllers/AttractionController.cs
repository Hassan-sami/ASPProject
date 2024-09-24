using Booking.Models;
using Booking.Models.Data;
using Booking.viewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Booking.Controllers
{
    public class AttractionController : Controller
    {
        private readonly UserManager<User>_manager;
        private readonly AppDbContext _context;

        public AttractionController(UserManager<User> manager, AppDbContext context)
        {
            this._manager = manager;
            this._context = context;
        }
        public async Task<IActionResult> DispalyAttraction()
        {
            AttractionViewModel viewModel = new AttractionViewModel();
            viewModel.User = await _manager.FindByNameAsync(User.Identity.Name);
            viewModel.TopHotels = _context.Hotels.Include(hotel => hotel.City).Where(hotel => hotel.StarsNo == 5).ToList();
            return View(viewModel);
        }
    }
}
