using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("tblBooks")]
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int Price { get; set; }

        public string Category { get; set; }

        // NEW FIELDS
        public int PublicationYear { get; set; }

        public int Stock { get; set; }


    }
}
