using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCBasket.Models
{
    public class Basket
    {

        public Basket()
        {
            Items = new List<BasketItem>();
        }
        public int Id { get; set; }

        public int? CustomerId { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }


        public decimal Total { get; set; }
        public decimal TotalVat { get; set; }

        public decimal TotalPrice { get; set; }
        public decimal TotalDiscount { get; set; }


        public List<BasketItem> Items { get; set; } = [];
        public int? Status { get; set; }
        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }
        public bool? IsActive { get; set; } = true;

        public bool? IsDeleted { get; set; } = false;

    }
}
