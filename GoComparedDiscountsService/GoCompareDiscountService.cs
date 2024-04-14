using BookManager.Services.Interfaces;
using GoCompareShop.DAL;
using GoCompareShop.Models;
using Microsoft.EntityFrameworkCore;
using NLog;

namespace GoComparedDiscountsService
{
    public class GoComparedDiscountsService
    {
        IGoCompareShopBasketInterface _iGoCompareShop;
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
        /// Applies the multy buy discount.
        /// </summary>
        /// <param name="SKU">The sku.</param>
        /// <param name="CustomerId">The customer identifier.</param>
        /// <param name="promotionStartDate">The promotion start date.</param>
        /// <param name="promotionEndDate">The promotion end date.</param>
        /// <returns></returns>
        private decimal ApplyMultyBuyDiscount(string sKU, int customerId, DateTime promotionStartDate, DateTime promotionEndDate)
        {
            decimal bestDiscount = 0;
            var groupDisocunts = _dbContext.DiscountGroups.Where(w => w.SKU == sKU && w.CustomerId == -customerId && w.StartDate <= promotionStartDate && w.EndDate == promotionEndDate && w.IsActive == true && w.IsDeleted == false).ToList();

            if (groupDisocunts != null)
            {
                foreach (var voucher in groupDisocunts)
                {

                }


            }
            // Loop through vouchers and calculate potential discount

            //{
            //    var discount = voucher.CalculateDiscount(price);
            //    if (discount > bestDiscount)
            //    {
            //        bestDiscount = discount;
            //    }
            //}

            return bestDiscount;
        }
    }
}
