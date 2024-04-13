namespace Basket.Models
{
    public class BasketItem

    {

        public string Id { get; set; }
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? OldUnitPrice { get; set; }
        public int? Quantity { get; set; }
        public string? PictureUrl { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }
        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;

    }
}
