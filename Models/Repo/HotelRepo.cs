using Booking.Models.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Booking.Models.Repo
{
    public class HotelRepo : Repository<Hotel>, IHotelRepo
    {
        private readonly AppDbContext _context;

        public HotelRepo(AppDbContext context) : base(context)
        {
            this._context = context;
        }

        public List<Hotel> Filter(Expression<Func<Hotel, bool>> filter)
        {
            return _context.Hotels.Where(filter).ToList();
        }

        public List<Hotel> GetHotels()
        {
            return _context.Hotels.ToList();
        }


    }
}
