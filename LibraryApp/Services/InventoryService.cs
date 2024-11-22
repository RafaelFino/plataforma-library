using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp.Domains;
using LibraryApp.Storage;

namespace LibraryApp.Services
{
    public class InventoryService
    {
        public IEnumerable<InventoryItem> GetInventoryItems()
        {
            throw new NotImplementedException();
        }
        
        public InventoryItem GetInventoryItem(int id)
        {
            throw new NotImplementedException();
        }
        
        public bool CreateInventoryItem(InventoryItem inventoryItem)
        {
            throw new NotImplementedException();
        }        
        
        public bool UpdateInventoryItem(InventoryItem inventoryItem)
        {
            throw new NotImplementedException();
        }

        public bool DeleteInventoryItem(int id)
        {
            throw new NotImplementedException();
        }        
        
        public IEnumerable<InventoryItem> GetInventoryItemsByBookId(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}