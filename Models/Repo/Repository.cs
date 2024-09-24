namespace Booking.Models.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(T item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Delete(T item)
        {
            _context.Remove(item);

            _context.SaveChanges();

        }


        public  T FindById(int id)
        {
            return _context.Find<T>(id);
            
        }

        public void Update(T item)
        {
            _context.Update<T>(item);
            _context.SaveChanges();
        }
    }
}
