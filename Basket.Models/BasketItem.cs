using System.ComponentModel.DataAnnotations.Schema;

namespace Basket.Models
{
    public class BasketItem

    {

        public string Id { get; set; }

        public string? CustomerId { get; set; }

        public string? BarCode { get; set; }
        public DateTime? ScanDateTime { get; set; }

        public string? Description { get; set; }

        public string? Name { get; set; }

        public string? SKU { get; set; }
        public Guid? BasketId { get; set; }
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? UnitPrice { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? OldUnitPrice { get; set; }
        public int? Quantity { get; set; }
        public string? PictureUrl { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }
        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;

    }
}
