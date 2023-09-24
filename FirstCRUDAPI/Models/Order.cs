using FirstCRUDAPI.States;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstCRUDAPI.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }
        public decimal TotalPrice{ get; set; }
        public OrderCategory OrderType{ get; set; }
        public DateTime TimeOrder{ get; set; }
        public bool Paid { get; set; }
        public DateTime TimePaid{ get; set; }
        public int SeatId{ get; set; }


        public List<User> UserId { get; set; }
        public List<Product> ProductId{ get; set; }
    }
}
