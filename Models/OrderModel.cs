using System.ComponentModel.DataAnnotations;

namespace Resting.Models
{
    public class OrderModel
    {
        [Key]
        public int OrderId { get; set; }

        public string Uid { get; set; }

        public string OrderDate { get; set; }

        public int TotalPrice { get; set; }

        public string Status {  get; set; } //e,g pending, completed or shipped
    }
}
