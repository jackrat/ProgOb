using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Delegacje_predefiniowane
{

 

  class Actions
  {
    public static void PriceGrow(Product prod, double perc)
    {
      prod.Price *= (1 + (perc / 100));
    }

    public static void ChangeExpirationByPercent(Product prod, double percent)
    {
      double byDays = (prod.ExpirationDate - prod.ProductionDate).TotalDays * (percent / 100);
      prod.ExpirationDate += TimeSpan.FromDays(byDays);
    }



    public static void ChangeProductionDate(Product prod, TimeSpan span)
    {
      prod.ProductionDate += span;
    }

    public static void ChangeProductionDateRound(Product prod, TimeSpan span)
    {
      span = TimeSpan.FromDays(Math.Round(span.TotalDays));
      prod.ProductionDate += span;
      prod.ProductionDate = prod.ProductionDate.Date;
    }



    public static void ChangePricesToMax(Product A, Product B)
    {
      if (A.Price > B.Price)
        B.Price = A.Price;
      else if (A.Price < B.Price) A.Price = B.Price;
    }

    public static void ChangePricesToAvg(Product A, Product B)
    {
      double avg = (A.Price + B.Price) / 2;
      A.Price = avg;
      B.Price = avg;
    }
  }
}
