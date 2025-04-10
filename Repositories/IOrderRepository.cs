namespace EasyGroceries.API.Repositories
{
    using EasyGroceries.API.Models;

    public interface IOrderRepository
    {
        void Save(Order order);
        Order? GetById(int orderId);
    }
}