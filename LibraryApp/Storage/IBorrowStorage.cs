using LibraryApp.Domains;

namespace LibraryApp.Storage
{
    public interface IBorrowStorage
    {
        IEnumerable<Borrow> GetBorrows();
        Borrow GetBorrow(int id);
        bool CreateBorrow(Borrow borrow);
        bool UpdateBorrow(Borrow borrow);
        bool DeleteBorrow(int id);
        IEnumerable<Borrow> GetBorrowsByUserId(int userId);
        IEnumerable<Borrow> GetBorrowsByInventoryId(int inventoryId);
        IEnumerable<Borrow> GetBorrowsByBookId(int bookId);
    }    
}
