using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp.Domains;
using LibraryApp.Storage;

namespace LibraryApp.Services
{
    public class CatalogService
    {
        public IEnumerable<Book> GetBooks()
        {
            throw new NotImplementedException();
        }
    
        public Book GetBook(int id)
        {
            throw new NotImplementedException();
        }
        public bool CreateBook(Book book)
        {
            throw new NotImplementedException();
        }
    
        public bool UpdateBookAsync(Book book)
        {
            throw new NotImplementedException();
        }
    
        public bool DeleteBookAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}