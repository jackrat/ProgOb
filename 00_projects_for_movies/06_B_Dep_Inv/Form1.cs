using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_B_Dep_Inv
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    Random rnd = new Random();





    private void button1_Click(object sender, EventArgs e)
    {
      Figura f = new Figura(CreateGraphics());
      f.Pars = losujPars();
      f.RysujZ();
    }


    //==================================================

    Kreslarnia kresl = new Kreslarnia();
    AFigura f;

    int[] losujPars()
    {
      return new int[] { rnd.Next(Width - 100), rnd.Next(Height - 70), 100, 70 };
    }


    private void button2_Click(object sender, EventArgs e)
    {
      f = new Figura(CreateGraphics());
    }
    private void button3_Click(object sender, EventArgs e)
    {
      f = new Prostokat(CreateGraphics());
    }

    private void button6_Click(object sender, EventArgs e)
    {
      kresl.UzyjZ(f, losujPars());
    }


    private void button4_Click(object sender, EventArgs e)
    {
      kresl.UzyjV(f, losujPars());
    }


  }
}
