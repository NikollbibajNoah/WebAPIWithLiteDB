using WebAPI.Model;

namespace WebAPI.Services.Implementation
{
    public class StoreService(DatabaseService databaseService) : IStoreservice
    {
        public async Task<IEnumerable<StoreItem>> GetAll()
        {
            return await databaseService.LoadCollection();
        }
        
        public async Task<StoreItem> GetItemById(int id)
        {
            return await databaseService.SelectById(id);
        }
        
        public async Task<StoreItem> CreateStoreItem(StoreItem newItem)
        {
            return await databaseService.CreateItem(newItem);
        }
        
        public async Task<StoreItem> UpdateStoreItem(int id, StoreItem updatedItem)
        {
            return await databaseService.UpdateItem(id, updatedItem);
        }
        
        public async Task<StoreItem> DeleteStoreItem(int id)
        {
            return await databaseService.DeleteItem(id);
        }
    }
}
