using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Dziedziczenie_cd
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }



    class B
    {
      public void MetZ()
      {
        MessageBox.Show("Jesteśmy w\r\n B.MetZ()");
      }
      public virtual void MetV()
      {
        MessageBox.Show("Jesteśmy w\r\n B.MetV()");
      }
    }
    class P : B
    {
      public void MetZ()
      {
        MessageBox.Show("Jesteśmy w\r\n P.MetZ()");
      }
      public override void MetV()
      {
        MessageBox.Show("Jesteśmy w\r\n P.MetV()");
      }
    }

    B b;
    P p;

    private void button1_Click(object sender, EventArgs e)
    {
      b = new B();
      b.MetZ();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      p = new P();
      p.MetZ();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      b = new P();
      b.MetZ();
    }

    private void button4_Click(object sender, EventArgs e)
    {

      //niedozwolone
      //p = new B();
      //p.MetZ();
    }

    private void button8_Click(object sender, EventArgs e)
    {
      b = new B();
      b.MetV();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      p = new P();
      p.MetV();
    }

    private void button6_Click(object sender, EventArgs e)
    {
      b = new P();
      b.MetV();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      //niedozwolone
      //p = new B();
      //p.MetV();
    }
  }
}
