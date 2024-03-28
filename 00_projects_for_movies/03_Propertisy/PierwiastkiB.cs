using _02_1_Pierwiastki_A;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Propertisy
{
  class PierwiastkiB : INotifyPropertyChanged
  {
    public double A
    {
      get { return a; }
      set
      {
        a = value;
        Oblicz();
        Propagate("A");
      }
    }
    private double a;

    public double B
    {
      get { return b; }
      set
      {
        b = value;
        Oblicz();
        Propagate("B");
      }
    }
    private double b;

    public double C
    {
      get { return c; }
      set
      {
        c = value; Oblicz();
        Propagate("C");
      }
    }
    private double c;

    public double[] Wynik
    {
      get { return wynik; }
    }
    double[] wynik;

    public double Delta
    {
      get { return delta; }
      private set { delta = value; }
    }
    private double delta;

    private void Oblicz()
    {
      delta = b * b - 4 * a * c;
      if (delta < 0)
      {
        wynik = new double[0];
        WynikStr = "Brak....";
      }
      else
       if (delta == 0)
      {
        wynik = new double[1];
        wynik[0] = -b / (2 * a);
        //wynik = new double[] { -b / (2 * a) };
        WynikStr = $"x0 = {wynik[0]}";
      }
      else
      {
        wynik = new double[2];
        wynik[0] = (-b - Math.Sqrt(delta)) / (2 * a);
        wynik[1] = (-b + Math.Sqrt(delta)) / (2 * a);
        WynikStr = $"x1 = {wynik[0]}\r\nx2 = {wynik[1]}";
      }
    }




    public string WynikStr
    {
      get { return wynikStr; }
      private set
      {
        wynikStr = value;
        Propagate("WynikStr");
      }
    }
    private string wynikStr;

    public event PropertyChangedEventHandler PropertyChanged;


    private void Propagate(string pn)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(pn));
      }
    }
  }
}
