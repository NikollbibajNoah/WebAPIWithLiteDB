using LiteDB;
using WebAPI.Model;
namespace WebAPI.Implementation
{
    public class DatabaseService
    {
        public string DatabaseName { get; set; } = @"./Store.db";
        public string CollectionName { get; set; } = "storeItems";
        public DatabaseService() { }

        public async Task<IEnumerable<StoreItem>> LoadCollection()
        {
            return await Task.Run(() =>
            {
                using var db = new LiteDatabase(DatabaseName);

                var col = db.GetCollection<StoreItem>(CollectionName);
                return col.FindAll().ToList();
            });
        }

        public async Task<StoreItem> SelectById(int id)
        {
            return await Task.Run(() =>
            {
                using var db = new LiteDatabase(DatabaseName);

                var col = db.GetCollection<StoreItem>(CollectionName);
                return col.FindById(id);
            });
        }

        public async Task<StoreItem> CreateItem(StoreItem newItem)
        {
            return await Task.Run(() =>
            {
                using var db = new LiteDatabase(DatabaseName);

                var col = db.GetCollection<StoreItem>(CollectionName);

                col.Insert(newItem);
                db.Commit();

                return newItem;
            });
        } 

        public async Task<StoreItem> UpdateItem(int id, StoreItem updatedItem)
        {
            return await Task.Run(() =>
            {
                using var db = new LiteDatabase(DatabaseName);

                var col = db.GetCollection<StoreItem>(CollectionName);
                var temp = col.FindById(id);

                temp = updatedItem;

                col.Update(temp);

                return temp;
            });
        }

        public async Task<StoreItem> DeleteItem(int id)
        {
            return await Task.Run(() =>
            {
                using var db = new LiteDatabase(DatabaseName);

                var col = db.GetCollection<StoreItem>(CollectionName);
                var deletedItem = col.FindById(id);
                col.Delete(id);

                return deletedItem;
            });
        }
    }
}
