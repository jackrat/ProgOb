using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_1_Metody
{
  public class Class1
  {
    public string S { get; set; }
    public DateTime d;
    public int[] t;

    public Class1()
    {
      S = "Dzień dobry";
      d = DateTime.Today;
      t = new int[] { 1, 2, 3 };
    }


    public Class1(string s, DateTime d, int[] t)
    {
      S = s;
      this.d = d;
      this.t = t;
    }
  }
}
