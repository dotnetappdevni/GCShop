﻿using System;
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
        public string? SKU { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
        public int? BarCode { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? BasketOfferPrice { get; set; }

        public int? DiscountType { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? DiscountValue { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? MinimumPurchaseQuantity { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? MaxiumPurchaseQuantity { get; set; }

        public bool? IsEnabled { get; set; }

        public bool? IsActive { get; set; } 
        public bool? IsDeleted { get; set; } 
    }
}
