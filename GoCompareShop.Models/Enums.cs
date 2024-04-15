using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCompareShop.Models
{
    public static class Enums
    {
        public enum DiscountTypeEnum
        {
            MultiBuy = 1,
            Percentage = 2,
            FixedAmount = 3,
            Seasonal = 4,
            Voucher = 5,
            Bundle = 6,
            Loyalty = 9,
            Student = 10,
            Employee = 11,
            SpecialPromotion = 12,
            Clearance = 13
        }

        public enum AvailabilityEnum
        {
            InStock = 1,
            OutOfStock = 2,
            OnOrder = 3,
            Discontinued = 4,
            DisablePurchase = 5
        }
    }
}
