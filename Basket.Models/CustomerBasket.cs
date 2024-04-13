using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket.Models
{
    public class CustomerBasket
    {
        public int Id { get; set; }

        public int? CustomerId { get; set; }

        public List<BasketItem> Items { get; set; } = [];

        public CustomerBasket() { }

        public CustomerBasket(int customerId)
        {
            CustomerId = customerId;
        }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }
        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;
    }
}
