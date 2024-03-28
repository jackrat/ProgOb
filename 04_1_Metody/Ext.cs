using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_1_Metody
{
  public static class Ext
  {
    public static string Bez3PierwszychiOstatnich(this string s)
    {
      if (s.Length >= 6)
        return s.Substring(3, s.Length - 6);
      else
        return null;
    }


    public static DateTime DodajDoDtDni(DateTime dt, int i)
    {
      return dt.AddDays(i);
    }

    public static DateTime DodajDoDtDni(this Class1 c, int i)
    {
      return c.d.AddDays(i);
    }

  }
}
