using GCBasket.Models;
using GoCompareShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GoCompareShop.Models.Enums;

namespace GoComparedDiscounts.Service.Interface
{
    public interface IGoCompareDiscountInterface
    {
        GoCCustomReturnObject ApplyDiscounts(string productSku, DiscountTypeEnum discountTypeEnum);

        void AddItem(Item item);

        void AddPricesBySkus(string skus);


    }
}
