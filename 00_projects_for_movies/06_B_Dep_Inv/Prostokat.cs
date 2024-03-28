using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_B_Dep_Inv
{
  class Prostokat : AFigura
  {
    public Prostokat(Graphics ag) : base(ag) { }
    new public void RysujZ()
    {
      gr.DrawRectangle(Pens.Magenta, Pars[0], Pars[1], Pars[2], Pars[3]);      
    }

    public override void RysujV()
    {
      gr.DrawRectangle(Pens.Magenta, Pars[0], Pars[1], Pars[2], Pars[3]);
    }
  }
}
