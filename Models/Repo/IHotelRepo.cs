using Booking.Models.Data;
using System.Linq.Expressions;

namespace Booking.Models.Repo
{
    public interface IHotelRepo : IRepository<Hotel>
    {
        public List<Hotel> GetHotels();

        

        List<Hotel> Filter(Expression<Func<Hotel, bool>> filter);
    }
}
