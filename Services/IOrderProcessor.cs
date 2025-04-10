namespace EasyGroceries.API.Services
{
    using EasyGroceries.API.Models;

    public interface IOrderProcessor
    {
        Order ProcessOrder(Order order);
        ShippingSlip GenerateShippingSlip(Order order);
    }
}