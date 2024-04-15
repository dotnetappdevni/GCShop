using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCompareShop.Models
{

    public class Item
    {
        public int Id { get; set; }

        public string? Sku { get; set; }

        public string? Name { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Price { get; set; }
        public decimal? DiscountQuantity { get; set; }
        public decimal? DiscountPrice { get; set; }

        public bool? IsDeleted { get; set; } = false;

        public bool? IsActive { get; set; } = true;

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? DateDeleted { get; set; }
    }
}
