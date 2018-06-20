using System;

namespace DiscountTA
{
   enum TdscType { dscFixed, dscPercentage }
   class clDiscount
   {
      private string dscDescription;
      private TdscType dscType;
      private double dscAmount;
      public string Description { get { return dscDescription; } }
      public double GetDiscountAmount(double inGross)
      {
         if(dscType == TdscType.dscFixed)
            return dscAmount;
         else
            return Math.Round(inGross * (dscAmount / 100.00), 2);
      }
      public clDiscount(string inDescription, TdscType inType, double inAmount)
      {
         dscDescription = inDescription;
         dscType = inType;
         dscAmount = inAmount;
      }

   }
}
