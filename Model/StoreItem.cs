namespace WebAPI.Model
{
    public class StoreItem
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public StoreItem() { }
    }
}
