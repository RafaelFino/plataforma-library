using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp.Domains;
using LibraryApp.Storage;

namespace LibraryApp.Services
{
    public class BorrowService
    {
        public IEnumerable<Borrow> GetBorrows()
        {
            throw new NotImplementedException();
        }
        public Borrow GetBorrow(int id)
        {
            throw new NotImplementedException();
        }
        public bool CreateBorrow(Borrow borrow)
        {
            throw new NotImplementedException();
        }
        public bool UpdateBorrow(Borrow borrow)
        {
            throw new NotImplementedException();
        }
        public bool DeleteBorrow(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Borrow> GetBorrowsByUserId(int userId)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Borrow> GetBorrowsByInventoryId(int inventoryId)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Borrow> GetBorrowsByBookId(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}