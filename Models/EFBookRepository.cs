using Microsoft.EntityFrameworkCore.Query;
using Mission11_TH.Models;

namespace Mission11_TH.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext _context;

        public EFBookRepository(BookstoreContext temp){
            _context = temp;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
