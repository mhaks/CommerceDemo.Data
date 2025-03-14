using System.ComponentModel.DataAnnotations;

namespace CommerceDemo.Data.Models
{
    public class ProductCategory
    {
        public int Id { get; set; } 
        
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; } = String.Empty;

    }
}
