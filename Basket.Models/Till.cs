using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCBasket.Models
{
    public class Till
    {
        public int Id { get; set; }

        public string? BarCode { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        public int? Location { get; set; }

        public int? Status { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }
        public bool? IsActive { get; set; } = true;

        public bool? IsDeleted { get; set; } = false;

    }
}
