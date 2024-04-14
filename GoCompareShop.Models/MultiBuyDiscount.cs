using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCompareShop.Models
{
    public class MultiBuyDiscount
    {
        public int Id { get; set; }

        
        public int? CustomerId { get; set; }

        public string? SKU { get; set; }

        public DateTime? StartDate { get; set; } = DateTime.Now;

        public DateTime? EndDate { get; set; }
        public string? BarCode { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double DiscountPercentage { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? NumberOfItemsForOffer { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? MaxiumNumerOfItemsForOffer { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? OfferPrice { get; set; }
        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }
        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;
    }
}
