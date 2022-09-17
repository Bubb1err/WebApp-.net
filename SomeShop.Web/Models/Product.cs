using System.ComponentModel.DataAnnotations;

namespace SomeShop.Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Key]
        public int CategoryId { get; set; }

    }
}
