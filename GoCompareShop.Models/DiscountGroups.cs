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

        public String? Name { get; set; }
        public int? CustomerId { get; set; }
        public string? SKU { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? DiscountPrice { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? DiscountQuantity { get; set; }
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
        

        public bool? IsEnabled { get; set; }

        public bool? IsActive { get; set; } 
        public bool? IsDeleted { get; set; } 
    }
}
