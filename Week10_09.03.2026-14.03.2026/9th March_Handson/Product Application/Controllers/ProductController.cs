using Microsoft.AspNetCore.Mvc;
using Product_Application.Services;

public class ProductsController : Controller
{
    private readonly IProductService _service;

    public ProductsController(IProductService service)
    {
        _service = service;
    }

    public IActionResult List()
    {
        var products = _service.GetProducts();
        return View(products);
    }
}

