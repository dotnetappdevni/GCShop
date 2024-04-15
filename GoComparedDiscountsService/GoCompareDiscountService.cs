using GCBasket.Models;
using GoComparedDiscounts.Service.Interface;
using GoCompareShop.DAL;
using GoCompareShop.Models;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using NLog;
using System.Linq.Expressions;
using System.Reflection;
using static GoCompareShop.Models.Enums;

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
        /// Gets the price by product sku.
        /// </summary>
        /// <param name="sku">The sku.</param>
        /// <returns></returns>
        public void AddPricesBySkus(string skus)
        {
            List<Item> items = new List<Item>();
            foreach (char sku in skus)
            {
                var discountGroups = _dbContext.DiscountGroups.Where(w => w.IsActive == true && w.IsDeleted == false).ToList();
                foreach (var discountGroup in discountGroups)
                {
                    var priceList = _dbContext.PriceLists.Where(w => w.Sku== discountGroup.SKU).FirstOrDefault();
                    if (priceList != null)
                    {
                        AddItem(new Item
                        {
                            Name=discountGroup.SKU,
                            Sku = discountGroup.SKU,
                            DiscountQuantity = discountGroup.DiscountQuantity,
                            DiscountPrice = discountGroup.DiscountPrice,
                            Price = priceList.Price,
                            IsActive = true,
                            IsDeleted = false
                        }
                     );


                    }
                }
            }
        }


        private readonly Dictionary<string, Item> items = new Dictionary<string, Item>();

        public void AddItem(Item item)
        {
            if (!items.ContainsKey(item.Name))
                items[item.Name] = item;
        }


        /// <summary>
        /// Calculates the total discounts and applies them to the basket.
        /// </summary>
        /// <param name="productSku">The product sku.</param>
        /// <param name="discountTypeEnum">The discount type enum.</param>
        /// <returns></returns>
        public GoCCustomReturnObject ApplyDiscounts(string productSku ,DiscountTypeEnum discountTypeEnum)
        {

            GoCCustomReturnObject goCCustomReturnObject = new GoCCustomReturnObject();
            try
            {
                switch (discountTypeEnum)
                {

                    case DiscountTypeEnum.MultiBuy:

                        decimal? totalPrice = 0;

                        if (string.IsNullOrWhiteSpace(productSku))
                        {
                            goCCustomReturnObject.Data = 0;
                            return goCCustomReturnObject;
                        }


                        // Count how many times a letter appears
                        var occurrences = productSku.GroupBy(c => c.ToString())
                                                   .ToDictionary(g => g.Key, g => g.Count());

                        foreach (var item in occurrences)
                        {
                            if (items.TryGetValue(item.Key, out Item currentItem))
                            {

                                var TEST = item.Value;

                                if (currentItem.DiscountQuantity > 0 && item.Value >= currentItem.DiscountQuantity)
                                {
                                    decimal? discountsCount = item.Value / currentItem.DiscountQuantity;
                                    totalPrice += discountsCount * currentItem.DiscountPrice + (item.Value % currentItem.DiscountQuantity) * currentItem.Price;
                                }
                                else
                                {
                                    totalPrice += item.Value * currentItem.Price;
                                }
                            }
                        }

                        goCCustomReturnObject.Data = totalPrice;
                        goCCustomReturnObject.Succeeded = true;
                        goCCustomReturnObject.Messages.Add(new Error { Field = "message", Message = $"Successfully applied discount to skus {productSku}" });

                        return goCCustomReturnObject;

                    default:
                        break;


                      

                }


                return goCCustomReturnObject;
            }
            catch (Exception ex)
            {
                goCCustomReturnObject.Exception= ex;
                goCCustomReturnObject.Succeeded = false;
                goCCustomReturnObject.Errors.Add( new Error { Field="errorMessage" ,Message= "Error occoured in the ApplyDiscounts Method " });
                _logger.Error("Error occoured in the ApplyDiscounts Method ", ex);
            }

            return goCCustomReturnObject;

        }

    }    
}

