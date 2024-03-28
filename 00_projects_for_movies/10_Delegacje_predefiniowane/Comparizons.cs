using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Delegacje_predefiniowane
{
  class Comparizons
  {
    internal static int byNameComparizon(Product x, Product y)
    {
      return String.Compare(x.Name, y.Name);
    }

    internal static int byDescriptionComparizon(Product x, Product y)
    {
      return String.Compare(x.Description, y.Description);
    }

    internal static int byProductionComparizon(Product x, Product y)
    {
      if (x.ProductionDate < y.ProductionDate)
        return -1;
      else if (x.ProductionDate > y.ProductionDate)
        return 1;
      else
        return 0;
    }

    internal static int byPriceComparizon(Product x, Product y)
    {
      if (x.Price < y.Price)
        return -1;
      else if (x.Price > y.Price)
        return 1;
      else
        return 0;
    }

    internal static int byNameAndPriceComparizon(Product x, Product y)
    {
      int n = String.Compare(x.Name, y.Name);
      if (n != 0)
        return n;
      else
      {
        if (x.Price < y.Price)
          return -1;
        else if (x.Price > y.Price)
          return 1;
        else
          return 0;
      }

    }
  }
}
