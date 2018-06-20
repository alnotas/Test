using System.Collections.ObjectModel;

namespace DiscountTA
{
   class clOrderDiscounts : Collection<clDiscount>
   {
      private double dscsTotalGross;
      private string dscsVisualResult;
      public clOrderDiscounts(double inTotalGross)
      {
         dscsTotalGross = inTotalGross;
      }
      public string visualDiscount { get {
            return dscsVisualResult;
         } }
      public double CalcDiscount()
      {
         double CurrentGross = dscsTotalGross;
         double result = 0.00;
         double dsc;
         dscsVisualResult = "";
         for(int i = 0; i < this.Count; i++)
         {
            dsc = Items[i].GetDiscountAmount(CurrentGross);
            dscsVisualResult = dscsVisualResult + Items[i].Description + ": -" +dsc.ToString("0.00 €") + "\r\n";
            result += dsc;
            CurrentGross -= dsc;
         }
         return result;
      }


   }
}
