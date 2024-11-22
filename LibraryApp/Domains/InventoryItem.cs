using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Domains
{
    public class InventoryItem(int id, int bookId)
    {
        public int Id { get; } = id;
        public int BookId { get; } = bookId;
        public DateTime CreatedAt { get; set; }
        public string? Observation { get; set; }
    }
}