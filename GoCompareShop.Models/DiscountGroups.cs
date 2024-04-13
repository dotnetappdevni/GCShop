using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public int? BarCode { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }

        public int? DiscountType { get; set; }

        public decimal? DiscountValue { get; set; }

        public decimal? MinimumPurchaseQuantity { get; set; }

        public decimal? MaxiumPurchaseQauntity { get; set; }

        public bool? IsEnabled { get; set; } = true;

        public bool? IsActive { get; set; } = true;
        public bool? IsDeleted { get; set; } = false;
    }
}
