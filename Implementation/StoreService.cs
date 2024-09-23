using LiteDB;
using WebAPI.Model;

namespace WebAPI.Implementation
{
    public class StoreService(DatabaseService databaseService)
    {

        /// <summary>
        /// Returns all loaded items from Database
        /// </summary>
        /// <returns>List of all found items</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<StoreItem>> GetAll()
        {
            //return await Task.Run(() =>
            //{
            //    using var db = new LiteDatabase(@"C:\Users\Admin\Desktop\testdb.db");

            //    var col = db.GetCollection<StoreItem>("storeItems");
            //    return col.FindAll().ToList();
            //});
            return await databaseService.LoadCollection();
        }

        /// <summary>
        /// Returns single found item by given index number
        /// </summary>
        /// <param name="id">Individual index number</param>
        /// <returns>Found store item</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<StoreItem> GetItemById(int id)
        {
            return await databaseService.SelectById(id);
        }

        /// <summary>
        /// Creates new item for the store
        /// </summary>
        /// <param name="newItem">New item to insert into Database</param>
        /// <returns>Created and inserted new item</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<StoreItem> CreateStoreItem(StoreItem newItem)
        {
            return await databaseService.CreateItem(newItem);
        }

        /// <summary>
        /// Updates item from store by given index and updated item
        /// </summary>
        /// <param name="id">Individual index number</param>
        /// <param name="updatedItem">Item to be new updated</param>
        /// <returns>Updated inserted store item</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<StoreItem> UpdateStoreItem(int id, StoreItem updatedItem)
        {
            return await databaseService.UpdateItem(id, updatedItem);
        }

        /// <summary>
        /// Delete item from store by given index number
        /// </summary>
        /// <param name="id">Individual index number</param>
        /// <returns>Deleted item from store</returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<StoreItem> DeleteStoreItem(int id)
        {
            return await databaseService.DeleteItem(id);
        }
    }
}
