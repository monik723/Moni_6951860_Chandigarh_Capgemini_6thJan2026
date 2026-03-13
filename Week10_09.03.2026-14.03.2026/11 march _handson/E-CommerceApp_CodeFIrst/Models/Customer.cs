namespace E_CommerceApp_CodeFIrst.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
