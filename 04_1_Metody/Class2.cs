using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_1_Metody
{
  public class Class2 : Class1
  {
    public double X;
    public double Y;

    public Class2() : base()
    {
      X = Math.PI;
    }

    public Class2(string s, DateTime d, int[] t, double x) : base(s, d, t)
    {
      X = x;
    }

    public Class2(string s, DateTime d, int[] t, double x, double y) : this(s, d, t, x)
    {
      Y = y;
    }

  }
}
