using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_A_Delegacje
{

  public delegate void procedure();
  class klasaABC
  {
    public delegate void procka();
  }


  public delegate void delegacjaDoPracyProc(string napis, double liczba);


  public delegate string delegacjaDoPracyFun(string napis, double liczba);
}
