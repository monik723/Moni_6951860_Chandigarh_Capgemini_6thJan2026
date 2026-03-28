using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        // 🔹 LIST ORDERS
        public async Task<IActionResult> Index()
        {
            var orders = _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.ShippingDetail);

            return View(await orders.ToListAsync());
        }

        // 🔹 CREATE ORDER (GET)
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Name");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        // 🔹 CREATE ORDER (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int CustomerId, int ProductId, int Quantity, string Address)
        {
            // Create Order
            var order = new Order
            {
                CustomerId = CustomerId,
                OrderDate = DateTime.Now
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Create OrderItem
            var orderItem = new OrderItem
            {
                OrderId = order.Id,
                ProductId = ProductId,
                Quantity = Quantity
            };

            _context.OrderItems.Add(orderItem);

            // Create Shipping
            var shipping = new ShippingDetail
            {
                OrderId = order.Id,
                Address = Address,
                Status = "Pending"
            };

            _context.ShippingDetails.Add(shipping);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}