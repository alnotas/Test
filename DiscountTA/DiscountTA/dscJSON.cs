using System.Collections.Generic;

namespace DiscountTA
{
   public class JSONDiscountItem
   {
      public string Name { get; set; }
      public string Type { get; set; }
      public double Value { get; set; }
      public double Gross { get; set; }
      public double Total { get; set; }
   }

   public class JSONDiscount
   {
      public double TotalGross { get; set; }
      public double TotalDiscount { get; set; }
      public List<JSONDiscountItem> Discounts { get; set; }
      public JSONDiscount(){
            Discounts = new List<JSONDiscountItem>();
      }
   }
}
