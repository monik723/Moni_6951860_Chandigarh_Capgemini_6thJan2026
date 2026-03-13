using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("tblPublishers")]
    public class PublisherModel
    {
        [Key]
        public int PublisherId { get; set; }

        public string PublisherName { get; set; }

        public string City { get; set; }
    }
}