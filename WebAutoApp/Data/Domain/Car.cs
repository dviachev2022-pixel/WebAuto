using System.ComponentModel.DataAnnotations;

namespace WebAutoApp.Data.Domain
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public String Model { get; set; } = null!;
        public String Picture { get; set; } = null!;
        [Required]
        [Range(0, 500)]

        public int Quantity { get; set; }
        [Required]

        public decimal Price { get; set; }

        public virtual IEnumerable<Order>Orders { get; set; } = new List<Order>();
    }
}
