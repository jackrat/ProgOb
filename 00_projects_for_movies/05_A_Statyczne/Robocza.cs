using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Statyczne
{
  static class Robocza
  {
    public static string Met1()
    {
      return DateTime.Now.ToString("yyyy MMMM dd HH:mm:ss");
    }

    //nie można dodawać składników innych niż statyczne jeśli klasa jest statyczna
    //public int i;

    public static int j;

    //nie można dodawać składników innych niż statyczne jeśli klasa jest statyczna
    //public int K { get; set; }

    public static int L { get; set; }


  }


  class Robocza2
  {
    public static int L { get; set; }
    public int M;


    public static int N
    {
      get
      {
        //w obrębie metod i właściwości statycznych
        //nie można odwoływać się do składników niestatycznych
        //return M;
        return L;
      }
    }
  }


}
