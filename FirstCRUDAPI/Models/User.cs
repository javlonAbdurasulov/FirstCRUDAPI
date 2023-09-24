using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstCRUDAPI.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Number{ get; set; }
        public string Adress{ get; set; }

        public List<Order> OrderId { get; set; }

        public override string ToString()
        {
            return $"{Id},{Name},{Number},{Adress}";
        }

    }
}
