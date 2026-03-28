using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace ECommerceApp.Controllers
{
    [Authorize(Roles = "Admin")]   // 🔐 Protect Admin Access
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            // 🔥 Top 5 selling products (with Product Name)
            var topProducts = _context.OrderItems
                .Include(o => o.Product)
                .GroupBy(o => new { o.ProductId, o.Product.Name })
                .Select(g => new
                {
                    ProductName = g.Key.Name,
                    TotalSold = g.Sum(x => x.Quantity)
                })
                .OrderByDescending(x => x.TotalSold)
                .Take(5)
                .ToList();

            // 🚚 Pending shipments
            var pendingOrders = _context.ShippingDetails
                .Where(s => s.Status == "Pending")
                .ToList();

            ViewBag.TopProducts = topProducts;
            ViewBag.PendingOrders = pendingOrders;

            return View();
        }
    }
}