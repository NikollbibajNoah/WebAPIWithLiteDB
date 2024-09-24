using WebAPI.Model;

namespace WebAPI.Services
{
    public interface IStoreservice
    {
        /// <summary>
        /// Returns all loaded items from Database
        /// </summary>
        /// <returns>List of all found items</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<IEnumerable<StoreItem>> GetAll();

        /// <summary>
        /// Returns single found item by given index number
        /// </summary>
        /// <param name="id">Individual index number</param>
        /// <returns>Found store item</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<StoreItem> GetItemById(int id);

        /// <summary>
        /// Creates new item for the store
        /// </summary>
        /// <param name="newItem">New item to insert into Database</param>
        /// <returns>Created and inserted new item</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<StoreItem> CreateStoreItem(StoreItem newItem);

        /// <summary>
        /// Updates item from store by given index and updated item
        /// </summary>
        /// <param name="id">Individual index number</param>
        /// <param name="updatedItem">Item to be new updated</param>
        /// <returns>Updated inserted store item</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<StoreItem> UpdateStoreItem(int id, StoreItem updatedItem);

        /// <summary>
        /// Delete item from store by given index number
        /// </summary>
        /// <param name="id">Individual index number</param>
        /// <returns>Deleted item from store</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<StoreItem> DeleteStoreItem(int id);
    }
}
