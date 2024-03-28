using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Delegacje_predefiniowane
{
  class Functions
  {
    public static double AvgPriceFromProducts(IEnumerable<Product> prods)
    {
      double sum = 0;
      foreach (Product p in prods)
        sum += p.Price;
      return sum / prods.Count();
    }




    public static double AvgPriceFromCheapProducts(IEnumerable<Product> prods)
    {
      return prods.Where(p => p.Price < 50).Average(p => p.Price);
    }
  }
}

/*
 Product ggg(Product p) 
 {
   if(p.Price < 50)
    return p
   else 
    return null;
 }
 
 */