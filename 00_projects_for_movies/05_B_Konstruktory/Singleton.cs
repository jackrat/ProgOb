using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_B_Konstruktory
{
  public sealed class Sing
  {
    private Sing():base()
    {
    }
    public static Sing Singleton
    {
      get
      {        
        return InstaceHolder.instance;
      }
    }
    class InstaceHolder
    {
      static InstaceHolder() { }
      internal static readonly Sing instance = new Sing();
    }
  }
}
