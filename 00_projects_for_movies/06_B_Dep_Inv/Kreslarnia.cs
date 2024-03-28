using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_B_Dep_Inv
{
  class Kreslarnia
  {
    public void UzyjZ(AFigura afig, int[] args)
    {
      afig.Pars = args;
      afig.RysujZ();
    }

    public void UzyjV(AFigura afig, int[] args)
    {
      afig.Pars = args;
      afig.RysujV();
    }
  }
}
