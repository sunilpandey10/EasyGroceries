namespace EasyGroceries.API.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> Items { get; set; } = new();
        public decimal TotalAmount { get; set; }
        public bool HasLoyaltyMembership { get; set; }
        public string ShippingAddress { get; set; } = string.Empty;
    }
}