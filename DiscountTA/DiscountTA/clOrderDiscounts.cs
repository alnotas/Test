using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace DiscountTA
{
   class clDiscounts : Collection<clDiscount>
   {
      private double totalDiscount;
      private double totalGross;
      public double TotalDiscount
      {
         get
         {
            double result = 0.00;
            double CurrentGross = totalGross;
            double dsc;
            for(int i = 0; i < this.Count; i++)
            {
               Items[i].DiscountGross = CurrentGross;
               dsc = Items[i].DiscountTotal;
               result += dsc;
               CurrentGross -= dsc;
            }
            totalDiscount = result;
            return result;
         }
         set { totalDiscount = value; }
      }
      //Constructor
      public clDiscounts(string JSONInput)
      {
         JSONDiscount JSONdsc = JsonConvert.DeserializeObject<JSONDiscount>(JSONInput);
         totalGross = JSONdsc.TotalGross;  //Initial order amount, before discounts
         foreach(JSONDiscountItem JSONdscItem in JSONdsc.Discounts) //Create individual discounts
         {
            clDiscount DiscountItem = new clDiscount(JSONdscItem.Name,
                                                     (JSONdscItem.Type == "Fixed amount" ? TdscType.dscFixed : TdscType.dscPercentage),
                                                     JSONdscItem.Value);
            this.Add(DiscountItem);
         }
      }
      //Output - Result in JSON Form
      public JSONDiscount JSONObject //readonly
      {
         get
         {
            JSONDiscount JSONObj = new JSONDiscount();
            JSONObj.TotalGross = totalGross;
            JSONObj.TotalDiscount = totalDiscount;
            foreach(clDiscount DiscountItem in this.Items)
            {
               JSONObj.Discounts.Add(DiscountItem.JSONObject);
            }
            return JSONObj;
         }
      }

   }
}
