using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_B_Dep_Inv
{

  abstract class AFigura
  {
    protected Graphics gr;
    public int[] Pars;
    public AFigura(Graphics ag)
    {
      gr = ag;
    }
    public void RysujZ()
    {
      gr.DrawString("Nic nie robię! Jestem abstrakcją",
        new Font(FontFamily.GenericSerif, 18),
        Brushes.Black,
        Pars[0], Pars[1]
        );
    }
    public abstract void RysujV();
  }


  class Figura : AFigura
  {
    public Figura(Graphics ag) : base(ag) { }

    new public void RysujZ()
    {
      gr.DrawString("Nie mam kształtu!",
        new Font(FontFamily.GenericSerif, 18),
        Brushes.Red,
        Pars[0], Pars[1]
        );
    }
    public override void RysujV()
    {
      gr.DrawString("Nie mam kształtu!",
       new Font(FontFamily.GenericSerif, 18),
       Brushes.Red,
       Pars[0], Pars[1]
       );
    }
  }
}
