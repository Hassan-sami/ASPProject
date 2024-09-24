using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Booking.Models.Repo
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Update(T item);

        void Delete(T item);

        T FindById(int id);

        

        
        
    }
}
