using GoCompareShop.Models;
using GoCompareShop.Services.Interfaces;
using Microsoft.Identity.Client;
using NLog;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using GoCompareShop.Models;
using GoCompareShop.DAL;
using GCBasket.Models;
using System.Drawing.Text;
using System.Reflection;

namespace GoCompareShop.Services
{
    public class GoCompareShopBasketService : IGoCompareShopBasketInterface
    {
        IGoCompareShopBasketInterface _iGoCompareShop;
        Guid basketId = Guid.NewGuid();
        GoCShopErrorObject errorReturn;
        private readonly ApplicationDBContext _dbContext;
        private static readonly NLog.Logger _logger = LogManager.GetCurrentClassLogger();
        public GoCompareShopBasketService()
        {

        }

        public GoCompareShopBasketService(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
            errorReturn = new GoCShopErrorObject();

        }

        /// <summary>
        /// Removes the basket item.
        /// </summary>
        /// <param name="basketItem">The basket item.</param>
        /// <returns>Returns a GoCShopErrorObject error object</returns>
        public GoCShopErrorObject RemoveBasketItem(BasketItem basketItem)
        {
            string methodName = MethodBase.GetCurrentMethod().Name;
            string className = this.GetType().Name;

            var basketItemRecord = _dbContext.BasketItems.Where(w => w.BasketId == basketItem.BasketId).FirstOrDefault();
            if (basketItemRecord != null)
            {

                try
                {
                    _dbContext.BasketItems.Remove(basketItem);
                    _dbContext.SaveChanges();
                    errorReturn.Succeeded = true;
                    errorReturn.Messages.Add($"Item Saved to basket sucesfully item id {basketId}");

                }
                catch (Exception ex)
                {
                    _logger.Info($"Entered the {methodName} in the service {className}");
                    errorReturn.Succeeded = false;
                    errorReturn.Errors.Add(new GCError { Field = "errorMessage", Message = $"Item was not created {basketItem.SKU}" });

                }

            }

            return errorReturn;

        }

        /// <summary>
        /// Adds the basket item.
        /// </summary>
        /// <param name="basketItem">The basket item.</param>
        /// <returns>Returns a custom error object</returns>
        public GoCShopErrorObject AddBasketItem(BasketItem basketItem)
        {
            string methodName = MethodBase.GetCurrentMethod().Name;
            string className = this.GetType().Name;
            _logger.Info($"Entered the {methodName} in the service {className}");
            if (basketItem != null)
            {

                basketItem.BasketId = basketId;
                basketItem.DateCreated = DateTime.Now;
                basketItem.IsActive = true;
                basketItem.IsDeleted = false;
                try
                {
                    _dbContext.BasketItems.Add(basketItem);
                    _dbContext.SaveChanges();
                    errorReturn.Succeeded = true;
                    errorReturn.Messages.Add($"Item Saved to basket successfully item id {basketId}");
                }
                catch (Exception ex)
                {
                    _logger.Info($"Entered the {methodName} in the service {className}");
                    errorReturn.Succeeded = false;
                    errorReturn.Errors.Add(new GCError { Field = "errorMessage", Message = $"Item was not created  successfully{basketItem.SKU}" });

                }

            }
            return errorReturn;

        }


    }
}
