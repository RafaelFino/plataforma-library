using LibraryApp.Domains;

namespace LibraryApp.Storage
{

    public interface IInventoryStorage
    {
        IEnumerable<InventoryItem> GetInventoryItems();
        InventoryItem GetInventoryItem(int id);
        bool CreateInventoryItem(InventoryItem inventoryItem);
        bool UpdateInventoryItem(InventoryItem inventoryItem);
        bool DeleteInventoryItem(int id);
        IEnumerable<InventoryItem> GetInventoryItemsByBookId(int bookId);
    }

}
