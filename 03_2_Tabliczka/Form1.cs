using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_2_Tabliczka
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      tab = new Tabliczka();
      tab.Col1 = int.Parse(tbCol1.Text);
      tab.Col2 = int.Parse(tbCol2.Text);
      tab.Row1 = int.Parse(tbRow1.Text);
      tab.Row2 = int.Parse(tbRow2.Text);
      label1.Text = tab.Wynik;
    }

    Tabliczka tab;

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      tab.Col1 = int.Parse(tbCol1.Text);
      label1.Text = tab.Wynik;
    }
    private void tbCol2_TextChanged(object sender, EventArgs e)
    {
      tab.Col2 = int.Parse(tbCol2.Text);
      label1.Text = tab.Wynik;
    }
    private void tbRow1_TextChanged(object sender, EventArgs e)
    {
      tab.Row1 = int.Parse(tbRow1.Text);
      label1.Text = tab.Wynik;
    }
    private void tbRow2_TextChanged(object sender, EventArgs e)
    {
      tab.Row2 = int.Parse(tbRow2.Text);
      label1.Text = tab.Wynik;
    }
  }
}
