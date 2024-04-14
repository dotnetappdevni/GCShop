using GCBasket.Models;
using GoCompareShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Services.Interfaces
{
    public interface IGoCompareShopBasketInterface
    {

        GoCShopErrorObject RemoveBasketItem(BasketItem basketItem);
        GoCShopErrorObject AddBasketItem(BasketItem basketItem);


    }
}
