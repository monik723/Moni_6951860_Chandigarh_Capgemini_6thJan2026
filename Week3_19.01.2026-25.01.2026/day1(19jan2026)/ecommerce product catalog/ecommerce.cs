using System;
using System.Collections.Generic;

namespace EcommerceCatalog
{
    // ================= BASE PRODUCT CLASS =================
    class Product
    {
        // Encapsulation
        private int productId;
        private string name;
        protected double price;
        protected int stock;

        public Product(int id, string name, double price, int stock)
        {
            this.productId = id;
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public int GetId() => productId;
        public string GetName() => name;
        public double GetPrice() => price;
        public int GetStock() => stock;

        public void ReduceStock(int qty)
        {
            stock -= qty;
        }

        public virtual string GetCategory()
        {
            return "General";
        }

        public virtual void Display()
        {
            Console.WriteLine($"{productId} | {name} | {GetCategory()} | ₹{price} | Stock: {stock}");
        }
    }

    // ================= ELECTRONICS =================
    class Electronics : Product
    {
        public Electronics(int id, string name, double price, int stock)
            : base(id, name, price, stock) { }

        public override string GetCategory()
        {
            return "Electronics";
        }
    }

    // ================= CLOTHING =================
    class Clothing : Product
    {
        public Clothing(int id, string name, double price, int stock)
            : base(id, name, price, stock) { }

        public override string GetCategory()
        {
            return "Clothing";
        }
    }

    // ================= BOOKS =================
    class Books : Product
    {
        public Books(int id, string name, double price, int stock)
            : base(id, name, price, stock) { }

        public override string GetCategory()
        {
            return "Books";
        }
    }

    // ================= CUSTOMER =================
    class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }
    }

    // ================= CART =================
    class Cart
    {
        private List<Product> items = new List<Product>();

        public void AddToCart(Product p)
        {
            if (p.GetStock() > 0)
            {
                items.Add(p);
                p.ReduceStock(1);
                Console.WriteLine("Product added to cart!");
            }
            else
            {
                Console.WriteLine("Out of stock!");
            }
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.GetPrice();
            }
            return total;
        }

        public void ShowCart()
        {
            Console.WriteLine("\n--- CART ITEMS ---");
            foreach (var item in items)
            {
                item.Display();
            }
            Console.WriteLine("Total Amount: ₹" + GetTotal());
        }
    }

    // ================= ORDER =================
    class Order
    {
        public static void PlaceOrder(Customer c, Cart cart)
        {
            Console.WriteLine("\nOrder placed successfully by " + c.Name);
            Console.WriteLine("Payable Amount: ₹" + cart.GetTotal());
        }
    }

    // ================= MAIN CLASS =================
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            // Adding sample products
            products.Add(new Electronics(1, "Laptop", 60000, 5));
            products.Add(new Electronics(2, "Mobile", 25000, 10));
            products.Add(new Clothing(3, "T-Shirt", 799, 20));
            products.Add(new Clothing(4, "Jeans", 1999, 15));
            products.Add(new Books(5, "C# Programming", 499, 30));
            products.Add(new Books(6, "OOP Concepts", 399, 25));

            Console.Write("Enter Customer Name: ");
            Customer customer = new Customer(Console.ReadLine());

            Cart cart = new Cart();

            int choice;
            do
            {
                Console.WriteLine("\n--- E-COMMERCE MENU ---");
                Console.WriteLine("1. View All Products");
                Console.WriteLine("2. Filter by Category");
                Console.WriteLine("3. Add to Cart");
                Console.WriteLine("4. View Cart");
                Console.WriteLine("5. Place Order");
                Console.WriteLine("6. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        foreach (var p in products)
                            p.Display();
                        break;

                    case 2:
                        Console.WriteLine("Enter Category (Electronics / Clothing / Books): ");
                        string cat = Console.ReadLine();

                        foreach (var p in products)
                        {
                            if (p.GetCategory().Equals(cat, StringComparison.OrdinalIgnoreCase))
                                p.Display();
                        }
                        break;

                    case 3:
                        Console.Write("Enter Product ID to add: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Product found = products.Find(p => p.GetId() == id);
                        if (found != null)
                            cart.AddToCart(found);
                        else
                            Console.WriteLine("Product not found!");
                        break;

                    case 4:
                        cart.ShowCart();
                        break;

                    case 5:
                        cart.ShowCart();
                        Order.PlaceOrder(customer, cart);
                        break;
                }

            } while (choice != 6);
        }
    }
}
