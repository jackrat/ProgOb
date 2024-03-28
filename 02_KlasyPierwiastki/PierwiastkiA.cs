using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KlasyPierwiastki
{
  public class PierwiastkiA
  {
    public double a;
    public double b;
    public double c;
    public double delta;
    public double[] wynik;

    public void Oblicz()
    {

      delta = b * b - 4 * a * c;
      if (delta < 0)
        wynik = new double[0];
      else if (delta == 0)
        wynik = new double[] { -b / (2 * a) };
      else
        wynik = new double[] { (-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a) };

    }

    public string WynikJakoStr()
    {
      if (delta < 0)
        return "Brak!";
      else if (delta == 0)
        return $"x0 = {wynik[0]}";
      else
        return $"x1 = {wynik[0]}\r\nx2 = {wynik[1]}";
    }

    public void setA(string s)
    {
      double.TryParse(s, out a);
    }

    public void setB(string s)
    {
      double.TryParse(s, out b);
    }
    public void setC(string s)
    {
      double.TryParse(s, out c);
    }

    public void setABC(string s1, string s2, string s3)
    {
      setA(s1);
      setB(s2);
      setC(s3);
    }

    public PierwiastkiA() { }

    public PierwiastkiA(string s1, string s2, string s3)
    {
      setABC(s1, s2, s3);
    }



  }
}
