using System.ComponentModel.DataAnnotations;

namespace Order.Models.Domain
{
    public class Order
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The order name is required")]
        public string OrderName { get; set; }

        [Required(ErrorMessage = "The quantity is required")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "The unit price is required")]
        public decimal UnitPrice { get; set; }
    }
}
