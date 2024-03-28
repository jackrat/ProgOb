using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_D_Delegacje_Add
{

  public delegate void ProceduraBezp();

  interface sdgsdg
  {
    void ProceduraBezp();
  }

  static class Robo
  {
    public static void Met1()
    {
      MessageBox.Show("Metoda Robo.Met1()!");
    }

    public static void Met2()
    {
      MessageBox.Show("Metoda Robo.Met2()!");
    }

  }
}
