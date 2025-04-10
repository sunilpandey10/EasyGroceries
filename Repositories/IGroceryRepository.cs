namespace EasyGroceries.API.Repositories
{
    using EasyGroceries.API.Models;

    public interface IGroceryRepository
    {
        List<GroceryItem> GetAll();
        GroceryItem? GetById(int id);
    }
}