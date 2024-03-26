using Microsoft.EntityFrameworkCore.Query;

namespace Mission11_TH.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
