using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<BookModel> Books { get; set; }

        public DbSet<PublisherModel> Publishers { get; set; }  // NEW LINE
    }
}