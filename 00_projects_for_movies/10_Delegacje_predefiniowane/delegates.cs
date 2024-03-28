using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Delegacje_predefiniowane
{

  public delegate void dChangeByRatio(Product product, double ratio);
  public delegate void dChangeByTimeSpan(Product product, TimeSpan addTime);
  public delegate void dChangeByRelation(Product productA, Product productB);

}
