namespace CommerceDemo.Data.Models
{
    public class OrderHistory
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderId { get; set; }    
        public int OrderStatusId { get; set; }


        public Order Order { get; set; } = default!;
        public OrderStatus OrderStatus { get; set; } = default!;
    }
}
