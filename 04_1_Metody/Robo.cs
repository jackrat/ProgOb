using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_1_Metody
{
  public class Robo
  {
    public void Met01(int i1, string s1, bool b1)
    {
      MessageBox.Show($"Na wejściu: i1: {i1}  s1: {s1}  b1: {b1}");
      i1 = i1 * 2;
      s1 = s1 + " " + DateTime.Now.ToString("HH:mm:ss");
      b1 = !b1;
      MessageBox.Show($"Na wyjściu: i1: {i1}  s1: {s1}  b1: {b1}");
    }

    public void Met02(ref int i1, ref string s1, ref bool b1)
    {
      MessageBox.Show($"Na wejściu: i1: {i1}  s1: {s1}  b1: {b1}");
      i1 = i1 * 2;
      s1 = s1 + " " + DateTime.Now.ToString("HH:mm:ss");
      b1 = !b1;
      MessageBox.Show($"Na wyjściu: i1: {i1}  s1: {s1}  b1: {b1}");
    }

    public void Met03(out int i1, out string s1, out bool b1)
    {
      //MessageBox.Show($"Na wejściu: i1: {i1}  s1: {s1}  b1: {b1}");
      //i1 = i1 * 2;
      i1 = 1234;
      //s1 = s1 + " " + DateTime.Now.ToString("HH:mm:ss");
      s1 = "Ola ma psa " + DateTime.Now.ToString("HH:mm:ss");
      //b1 = !b1;
      b1 = true;
      MessageBox.Show($"Na wyjściu: i1: {i1}  s1: {s1}  b1: {b1}");
    }


    public void Met04(double[] d, Class1 c, DateTime dt)
    {
      MessageBox.Show($"Na wejściu: d[0]: {d[0]}  c.t[0]: {c.t[0]} c.d: {c.d} dt: {dt}");
      d[0] += 10;
      c.t[0] = 666;
      c.d = c.d.AddMonths(1);
      dt = dt.AddDays(1);
      c = new Class1();
      c.d = new DateTime(2000, 1, 1);
      c.t = new int[] { 6, 6, 6 };
      c.S = "A kuku";
      MessageBox.Show($"Na wyjściu: d[0]: {d[0]}  c.t[0]: {c.t[0]} c.d: {c.d} dt: {dt}");
    }

    public void Met05(ref double[] d, ref Class1 c, ref DateTime dt)
    {
      MessageBox.Show($"Na wejściu: d[0]: {d[0]}  c.t[0]: {c.t[0]} c.d: {c.d} dt: {dt}");
      d[0] += 10;
      c.t[0] = 666;
      c.d = c.d.AddMonths(1);
      dt = dt.AddDays(1);
      c = new Class1();
      c.d = new DateTime(2000, 1, 1);
      c.t = new int[] { 6, 6, 6 };
      c.S = "A kuku";
      MessageBox.Show($"Na wyjściu: d[0]: {d[0]}  c.t[0]: {c.t[0]} c.d: {c.d} dt: {dt}");
    }


    public static double ObliczPiRKwadrat(double r)
    {
      return Math.PI * r * r;
    }

    public static double ObliczPiRKwadrat(ref double r2)
    {
      return Math.PI * r2 * r2;
    }

    //public static double ObliczPiRKwadrat(out double r)
    //{
    //  r2 = 12;
    //  return Math.PI * r2 * r2;
    //}



    public static void metodaStat(int i, double d, string s, DateTime dt, decimal[] dec, Class1 c, int k = 123)
    {
      MessageBox.Show("Z k");
    }


    public static void metodaStat(int i, double d, string s, DateTime dt, decimal[] dec, Class1 c)
    {
      MessageBox.Show("Bez k");
    }

    public static void metodaStat(double d, int i, string s, DateTime dt, decimal[] dec, Class1 c)
    {
      MessageBox.Show("Bez k");
    }


    public static void KKK()
    { 
    }
    //public static string KKK()
    //{
    //  return "Ala ma kota";
    //}



  }
}
