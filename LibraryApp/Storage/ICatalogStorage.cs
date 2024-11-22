using LibraryApp.Domains;

namespace LibraryApp.Storage
{
    public interface ICatalogStorage
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        bool CreateBook(Book book);
        bool UpdateBookAsync(Book book);
        bool DeleteBookAsync(int id);
    }
}
