using GCBasket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoComparedDiscounts.Service.Interface
{
    public interface IGoCompareDiscountInterface
    {
        decimal? ApplyMultiBuyDiscount(Basket basket, int customerId);
    }
}
