public class OrderViewModel
{
    public Order Order { get; set; }
    public List<OrderItem> Items { get; set; }
    public ShippingDetail Shipping { get; set; }
}