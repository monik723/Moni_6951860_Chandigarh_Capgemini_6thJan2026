using BookAndAuthor.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAndAuthor.Data
{
    public class ApplicationDbContext : DbContext
    {
		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<AuthorBook> AuthorBooks { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AuthorBook>()
				.HasKey(ab => new { ab.AuthorId, ab.BookId });

			modelBuilder.Entity<AuthorBook>()
				.HasOne(ab => ab.Author)
				.WithMany(a => a.AuthorBooks)
				.HasForeignKey(ab => ab.AuthorId);

			modelBuilder.Entity<AuthorBook>()
				.HasOne(ab => ab.Book)
				.WithMany(b => b.AuthorBooks)
				.HasForeignKey(ab => ab.BookId);
		}
	}
}
