// Services/OrderProcessor.cs
namespace EasyGroceries.API.Services
{
    using EasyGroceries.API.Models;

    public class OrderProcessor : IOrderProcessor
    {
        public Order ProcessOrder(Order order)
        {
            foreach (var item in order.Items)
            {
                if (order.HasLoyaltyMembership)
                {
                    item.Price *= 0.8m; // Apply 20% discount
                }
            }
            order.TotalAmount = order.Items.Sum(i => i.Price * i.Quantity);
            return order;
        }

        public ShippingSlip GenerateShippingSlip(Order order)
        {
            var slip = new ShippingSlip
            {
                OrderId = order.OrderId,
                CustomerName = $"Customer: {order.CustomerId}",
                ShippingAddress = order.ShippingAddress,
                ProductLines = order.Items
                    .Where(i => i.IsPhysicalProduct)
                    .Select(i => $"{i.ItemName} – Qty: {i.Quantity}")
                    .ToList()
            };
            return slip;
        }
    }
}