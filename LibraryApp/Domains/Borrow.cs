using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Domains
{
    public class Borrow(int id, int userId, int inventoryId)
    {
        public int Id { get; } = id;
        public int UserId { get; } = userId;
        public int InventoryId { get; } = inventoryId;
        public DateTime BorrowedAt { get; set; }
        public DateTime? ReturnedAt { get; set; }        
    }
}