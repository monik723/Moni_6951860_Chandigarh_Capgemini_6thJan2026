namespace Product_Application.Services
{
    public interface IProductService
    {
        List<string> GetProducts();
    }

    // ProductService.cs
    public class ProductService : IProductService
    {
        public List<string> GetProducts()
        {
            return new List<string> { "Laptop", "Phone", "Tablet" };
        }
    }
}
