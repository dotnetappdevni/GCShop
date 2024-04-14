using GCBasket.Models;
using GoComparedDiscounts.Service.Interface;
using GoCompareShop.DAL;
using GoCompareShop.Models;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using NLog;
using System.Reflection;

namespace GoComparedDiscounts.Service
{
    public class GoComparedDiscountsService : IGoCompareDiscountInterface
    {
        IGoCompareDiscountInterface _iGoCompareShop;
        Guid basketId = Guid.NewGuid();
        GoCShopErrorObject errorReturn;
        private readonly ApplicationDBContext _dbContext;
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();
        public GoComparedDiscountsService()
        {

        }
        public GoComparedDiscountsService(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
            errorReturn = new GoCShopErrorObject();
        }

        /// <summary>
        /// Applies the multi buy discount and check if a customer is passed if not find the sku
        /// </summary>
        /// <param name="basket">The basket.</param>
        /// <param name="customerId">The customer identifier.</param>
        public decimal? ApplyMultiBuyDiscount(Basket basket, int customerId)
        {

            decimal? saving = 0.00m;
            var test = basket.Items.GroupBy(g => g.SKU);
            foreach (var item in basket.Items)
            {

                var checkDiscountGroups = _dbContext.DiscountGroups.Where(w => w.SKU == item.SKU|| w.CustomerId == customerId && w.IsActive == true && w.IsDeleted == false).FirstOrDefault();
                if (checkDiscountGroups != null)
                {
                    decimal? numberOfItemsPerOffer = checkDiscountGroups.MinimumPurchaseQuantity;

                    decimal? totalNumberOfItems = item.Quantity;

                    decimal? numberOfOffers = totalNumberOfItems / numberOfItemsPerOffer;

                    decimal? remainingItems = totalNumberOfItems % numberOfItemsPerOffer;

                    if (checkDiscountGroups != null)
                    {
                        var numberOfItems = item.Quantity;
                        decimal? minPurchaseQty = checkDiscountGroups.MinimumPurchaseQuantity;
                        if (numberOfItems > minPurchaseQty)
                        {
                            decimal? totalWithoutOffer = item.LinePrice * item.Quantity;

                            decimal? offerPrice = numberOfOffers * checkDiscountGroups.DiscountValue + remainingItems * item.LinePrice;

                            saving = totalWithoutOffer - offerPrice;

                            Console.WriteLine("Total without offer: $" + totalWithoutOffer);
                            Console.WriteLine("Offer price for the basket: $" + offerPrice);
                            Console.WriteLine("You save: $" + saving);

                        }
                    }
                }
                else
                {
                    _logger.Warn($"No Discount found for the sku {item.SKU} ,please check the system");


                }
            }

            return saving;
        }


        public void GenTestData()
        {
            Basket basket = new Basket();
            basket.Total = 150;
            basket.Id = 1;
            basket.Status = 1;
            basket.Items = new List<BasketItem> {  new BasketItem { SKU="A",Description="Test Basket Item",LinePrice=50.00m,Quantity=3,IsActive=true,IsDeleted=false},
             new BasketItem { SKU="B",Description="Test Basket Item 2",LinePrice=30.00m,Quantity=5,IsActive=true,IsDeleted=false}};
            basket.IsActive = true;
            basket.IsDeleted = false;
        }
    }
}
