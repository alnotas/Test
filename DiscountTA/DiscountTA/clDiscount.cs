using System;

namespace DiscountTA
{
   enum TdscType { dscFixed, dscPercentage }
   class clDiscount
   {
      private string discountName;
      private TdscType discountType;
      private double discountValue;
      private double discountGross;
      private double discountTotal;
      //------------------------------------------------------------//
      //Exposed because its value is not known upon creation but set on runtime
      public double DiscountGross { get { return discountGross; } set { discountGross = value; } }
      public double DiscountTotal
      {
         get
         {
            if(discountType == TdscType.dscFixed)
               discountTotal = discountValue;
            else
               discountTotal = Math.Round(discountGross * (discountValue / 100.00), 2);
            return discountTotal;
         }
         set { discountTotal = value; }
      }
      //Constructor
      public clDiscount(string inDiscountName, TdscType inDiscountType, double inValue)
      {
         discountName = inDiscountName;
         discountType = inDiscountType;
         discountValue = inValue;
      }
      //Output - Result in JSON Form
      public JSONDiscountItem JSONObject  //readonly
      {
         get
         {
            JSONDiscountItem JSONObj = new JSONDiscountItem();
            JSONObj.Name = discountName;
            JSONObj.Type = (discountType == TdscType.dscFixed ? "Fixed Amount" : "Percentage");
            JSONObj.Value = discountValue;
            JSONObj.Gross = discountGross;
            JSONObj.Total = discountTotal;
            return JSONObj;
         }
      }
   }
}
