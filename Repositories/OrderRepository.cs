namespace EasyGroceries.API.Repositories
{
    using EasyGroceries.API.Models;

    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new();
        private int _nextId = 1;

        public void Save(Order order)
        {
            order.OrderId = _nextId++;
            _orders.Add(order);
        }

        public Order? GetById(int orderId) => _orders.FirstOrDefault(o => o.OrderId == orderId);
    }
}
