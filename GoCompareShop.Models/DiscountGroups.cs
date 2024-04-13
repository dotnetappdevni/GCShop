using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCompareShop.Models
{
    public class DiscountGroup
    {
        public int Id { get; set; }

        public int? CustomerId { get; set; }
        public int? Sku { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
        public int? BarCode { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }

        public int? DiscountType { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? DiscountValue { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? MinimumPurchaseQuantity { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? MaxiumPurchaseQauntity { get; set; }

        public bool? IsEnabled { get; set; } = true;

        public bool? IsActive { get; set; } = true;
        public bool? IsDeleted { get; set; } = false;
    }
}
