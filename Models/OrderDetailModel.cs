namespace Resting.Models
{
    public class OrderDetailModel
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public string ProductId { get; set; }

        public int Quantity { get; set; }

        public int PriceAtTimeOfOrder { get; set; }
    }
}
