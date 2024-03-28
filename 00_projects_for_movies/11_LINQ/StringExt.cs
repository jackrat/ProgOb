using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_LINQ
{
  public static class StringExt
  {
    public static string First22Upper(this string s)
    {
      if (s.Length >= 2)
        return s.Substring(0, 2).ToUpper() + s.Substring(2, s.Length - 2);
      else
        return s;
    }
  }
}
