using GoComparedDiscounts.Service.Interface;
using GoCompareShop.CustomerService.Interface;
using GoCompareShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace GoCompareShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {

        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        private readonly IGoCompareDiscountInterface _goCompareDiscountInterface;

        public BasketController(IGoCompareDiscountInterface goCompareDiscountInterface)
        {
            _goCompareDiscountInterface = goCompareDiscountInterface;

        }

        /// <summary>
        /// Gets the basket totals of the  specified product skus.
        /// </summary>
        /// <param name="productSkus">The product skus.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Basket(string productSkus)
        {
            GoCCustomReturnObject basketTotals;
            GoCCustomReturnObject goCCustomReturnObject = new GoCCustomReturnObject();
            _goCompareDiscountInterface.AddPricesBySkus(productSkus);

            try
            {
                basketTotals = _goCompareDiscountInterface.ApplyDiscounts(productSkus, Models.Enums.DiscountTypeEnum.MultiBuy);

                if (basketTotals.Succeeded == true)
                {
                    goCCustomReturnObject.Messages.Add(new Models.Error { Field = "basketTotal",Message="Basket total successfully retrieved", data = basketTotals.Data });

                    return Ok(goCCustomReturnObject);

                }

            }
            catch (Exception ex)
            {
                goCCustomReturnObject.Errors.Add(new Models.Error { Field = "errorMessage", Message = "Basket total could not be calculated" });
                goCCustomReturnObject.Succeeded = false;

            }

            return Ok(goCCustomReturnObject);

        }

    }

}
