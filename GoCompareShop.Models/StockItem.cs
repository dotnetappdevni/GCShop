using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCompareShop.Models
{
    public class StockItem
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Category { get; set; }

        public string? BarCode { get; set; }

        public bool? HasMultiBuyDiscount { get; set; }

        public bool? IsDeleted { get; set; } = false;

        public bool? IsActive { get; set; } = true;

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }


        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

    }
}
