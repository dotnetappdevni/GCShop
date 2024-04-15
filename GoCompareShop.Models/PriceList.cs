using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCompareShop.Models
{
    public class PriceList
    {

        public int Id { get; set; }


        public string? Name { get; set; }


        public string? Description { get; set; }
        public string? Sku { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Availability { get; set; }
        public int? TaxCodeId { get; set; }
        public string? Currency { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Price { get; set; }
        public int? DiscountGroupId { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Uom { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? MinimumOrderQuantity { get; set; }

        public decimal? MaximumOrderQuantity { get; set; }
        public bool? IsEnabled { get; set; } = true;

        public bool? IsActive { get; set; } = true;
        public bool? IsDeleted { get; set; } = false;
    }
}
