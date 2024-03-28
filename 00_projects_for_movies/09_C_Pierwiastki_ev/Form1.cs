using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_C_Pierwiastki_ev
{
  public partial class Form1 : Form
  {
    private PierwiastkiEv pev = new PierwiastkiEv();

    public Form1()
    {
      InitializeComponent();
      pev.WynikGotowy += Pev_WynikGotowy;
    }

    private void Pev_WynikGotowy(object sender, EventArgs e)
    {
      label1.Text = "Wyniki: " + string.Join(" ,", pev.wynik);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      double aa;
      if (double.TryParse(textBox1.Text, out aa)) pev.A = aa;
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
      double bb;
      if (double.TryParse(textBox2.Text, out bb)) pev.B = bb;
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
      double cc;
      if (double.TryParse(textBox3.Text, out cc)) pev.C = cc;
    }
  }
}
