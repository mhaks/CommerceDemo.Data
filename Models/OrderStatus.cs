using System.ComponentModel.DataAnnotations;


namespace CommerceDemo.Data.Models
{
    
    public class OrderStatus
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = String.Empty;
    }

    public enum OrderState
    {
         Cart = 1,
         Processing = 2,
         Shipped = 3,
         Delivered = 4,
         Returned = 5,                      
    }
}
