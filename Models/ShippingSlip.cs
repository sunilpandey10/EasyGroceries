namespace EasyGroceries.API.Models
{
    public class ShippingSlip
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string ShippingAddress { get; set; } = string.Empty;
        public List<string> ProductLines { get; set; } = new();
    }
}
