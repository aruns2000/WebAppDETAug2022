using LibraryAPI.Models;

namespace LibraryAPI.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        BookService Add(Book newBook);
        BookService GetById(Guid id);
        void Remove(Guid id);
    }
}
