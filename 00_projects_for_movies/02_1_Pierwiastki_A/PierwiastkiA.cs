using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_1_Pierwiastki_A
{
  public class PierwiastkiA
  {
    public double a;
    public double b;
    public double c;
    public double[] wynik;
    public double delta;


    public void setA(string sa)
    {
      double x;
      if (double.TryParse(sa, out x))
        a = x;
    }
    public void setB(string sb)
    {
      double x;
      if (double.TryParse(sb, out x))
        b = x;
    }
    public void setC(string sc)
    {
      double x;
      if (double.TryParse(sc, out x))
        c = x;
    }

    public void setABC(string sa, string sb, string sc)
    {
      setA(sa);
      setB(sb);
      setC(sc);
    }

    public void Oblicz()
    {
      delta = b * b - 4 * a * c;
      if (delta < 0)
        wynik = new double[0];
      else
       if (delta == 0)
      {
        wynik = new double[1];
        wynik[0] = -b / (2 * a);
        //wynik = new double[] { -b / (2 * a) };
      }
      else
      {
        wynik = new double[2];
        wynik[0] = (-b - Math.Sqrt(delta)) / (2 * a);
        wynik[1] = (-b + Math.Sqrt(delta)) / (2 * a);
      }
    }


    public PierwiastkiA(double wa, double wb, double wc)
    {
      a = wa;
      b = wb;
      c = wc;
      Oblicz();
    }

    public PierwiastkiA() { }


    public PierwiastkiA(string sa, string sb, string sc)
    {
      setABC(sa, sb, sc);
      Oblicz();
    }


    public string WynikAsString()
    {
      string s;
      if (wynik.Length == 0)
        s = "Brak rozwiązań!";
      else
       if (wynik.Length == 1)
        s = string.Format("x0 = {0}", wynik[0]);
      else
        s = string.Format("x1 = {0}\r\nx2 = {1}", wynik[0], wynik[1]);

      return s;
    }

    public string szab0 = "Brak rozwiązań!";
    public string szab1 = "x0 = {0}";
    public string szab2 = "x1 = {0}\r\nx2 = {1}";

    public string WynikAsString2()
    {
      string s;
      if (wynik.Length == 0)
        s = szab0;
      else
       if (wynik.Length == 1)
        s = string.Format(szab1, wynik[0]);
      else
        s = string.Format(szab2, wynik[0], wynik[1]);

      return s;
    }

  }
}
