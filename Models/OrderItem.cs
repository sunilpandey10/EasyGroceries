namespace EasyGroceries.API.Models
{
    public class OrderItem
    {
        public int GroceryItemId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsPhysicalProduct { get; set; }
    }
}