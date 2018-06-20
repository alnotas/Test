using System;

namespace DiscountTA
{
    enum TdscType { dscFixed, dscPercentage }
    class clDiscount
    {
        private string discountName;
        private TdscType discountType;
        private double discountValue;
        public string DiscountName { get { return discountName; } }
        public clDiscount(string inDiscountName, TdscType inDiscountType, double inValue)
        {
            discountName = inDiscountName;
            discountType = inDiscountType;
            discountValue = inValue;
        }
        public double GetDiscountAmount(double inGross)
        {
            if (discountType == TdscType.dscFixed)
                return discountValue;
            else
                return Math.Round(inGross * (discountValue / 100.00), 2);
        }
    }
}
