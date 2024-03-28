using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_Properties
{
  public class Przyklad
  {
    public int N
    {
      get
      {
        return n;
      }
      set
      {
        n = value;
      }
    }

    private int n;


    public int M
    {
      get
      {
        return m;
      }
      private set
      {
        m = value;
      }
    }
    private int m;


    public void SetM(int v)
    {
      if ((v % 2) == 0)
        M = v;
    }


    public string S
    {
      get => s;
      set => s = value;
    }
    private string s;

    public double D { get => d; set => d = value; }
    private double d;

    public int I { get; set; }


    public int J { get; }
    public int K
    {
      set
      {
        ///// coś zrobione z ez zmienną value
        n = value;
      }
    }


    public int M2
    {
      get
      {
        return m2;
      }
      set
      {

        // Nazwa właściwosci w setterze jest powaznym błędem
        //if ((value % 2) == 0)
        //  M2 = value;

        if ((value % 2) == 0)
          m2 = value;
      }
    }
    private int m2;


    int k = 0;

  }
}
