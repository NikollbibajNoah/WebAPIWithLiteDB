using WebAPI.Model;

namespace WebAPI.Services
{
    public interface IDatabaseService
    {
        /// <summary>
        /// Loads entire collection of the database by the collection name
        /// </summary>
        /// <returns>List of all saved data in collection</returns>
        public Task<IEnumerable<StoreItem>> LoadCollection();

        /// <summary>
        /// Selects only a single column by the givend id number
        /// </summary>
        /// <param name="id">Individual id number</param>
        /// <returns>Single column data</returns>
        public Task<StoreItem> SelectById(int id);

        /// <summary>
        /// Inserts new column in table collection
        /// </summary>
        /// <param name="newItem">New column data to insert</param>
        /// <returns>Inserted data from table collection</returns>
        public Task<StoreItem> CreateItem(StoreItem newItem);

        /// <summary>
        /// Updates individual column by given id number and new item to replace
        /// </summary>
        /// <param name="id">Individual id number to select column</param>
        /// <param name="updatedItem">New data to replace in column</param>
        /// <returns>New updated column from the table at id</returns>
        public Task<StoreItem> UpdateItem(int id, StoreItem updatedItem);

        /// <summary>
        /// Deletes column at given id position from table collection
        /// </summary>
        /// <param name="id">Individual id number to delete</param>
        /// <returns>Removed column from table</returns>
        public Task<StoreItem> DeleteItem(int id);
    }
}
