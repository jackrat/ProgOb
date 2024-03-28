using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_C_Pierwiastki_ev
{
  class PierwiastkiEv
  {
    public double A
    {
      get { return a; }
      set
      {
        if (value != a)
        {
          a = value;
          Oblicz();
        }
      }
    }
    private double a;


    public double B
    {
      get { return b; }
      set
      {
        if (value != b)
        {
          b = value;
          Oblicz();
        }
      }
    }
    private double b;


    public double C
    {
      get { return c; }
      set
      {
        if (value != c)
        {
          c = value;
          Oblicz();
        }
      }
    }
    private double c;


    private double delta;

    public double[] wynik;

    private void Oblicz()
    {
      if (a != 0)
      {
        delta = b * b - 4 * a * c;
        if (delta < 0)
          wynik = new double[0];
        else if (delta == 0)
          wynik = new double[] { -b / (2 * a) };
        else
          wynik = new double[] { (-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a) };

        if (WynikGotowy != null)
          WynikGotowy(this, new EventArgs());
      }
    }

    public event EventHandler WynikGotowy;

  }
}
