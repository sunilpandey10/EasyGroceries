namespace EasyGroceries.API.Repositories
{
    using EasyGroceries.API.Models;

    public class GroceryRepository : IGroceryRepository
    {
        private readonly List<GroceryItem> _items = new()
        {
            new GroceryItem { Id = 1, Name = "Milk", Description = "The best of cows", Price = 2.5m },
            new GroceryItem { Id = 2, Name = "Bread", Description = "Easy toast", Price = 1.5m },
            new GroceryItem { Id = 3, Name = "Eggs", Description = "Wild chicken", Price = 3m },
            new GroceryItem { Id = 4, Name = "Loyalty Membership", Description = "20% Discount on all orders", Price = 5m, IsPhysicalProduct = false }
        };

        public List<GroceryItem> GetAll() => _items;

        public GroceryItem? GetById(int id) => _items.FirstOrDefault(i => i.Id == id);
    }
}