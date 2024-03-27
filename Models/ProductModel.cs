using System.ComponentModel.DataAnnotations;

namespace Resting.Models
{
    public class ProductModel
    {
        [Key]
        public string ProductId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string price { get; set; }
        public int StockQuantity { get; set; }

        public string CategoryID { get; set; }



    }
}
