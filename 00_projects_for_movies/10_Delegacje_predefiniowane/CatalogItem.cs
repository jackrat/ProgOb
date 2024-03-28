using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Delegacje_predefiniowane
{
  public class CatalogItem
  {
    public string Symbol { get; set; }
    public string Caption { get; set; }
    public string PriceRange { get; set; }
    public override string ToString()
    {
      return string.Format("{0}-{1}\r\n{2}", Symbol, Caption, PriceRange);
    }
  }
}
