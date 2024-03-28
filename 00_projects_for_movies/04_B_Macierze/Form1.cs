using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Macierze
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }


    Matrix a = new Matrix(3, 4);
    Matrix b = new Matrix(3, 4);
    Matrix c;
    private void button1_Click(object sender, EventArgs e)
    {
      a.Losuj();
      label1.Text = a.AsString;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      b.Losuj();
      label2.Text = b.AsString;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      c = a.Dodaj(b);
      label3.Text = c.AsString;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      c = a + b;
      label3.Text = c.AsString;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      double dd = c.Values[0, 0];
      dd = c[0, 0];
      dd = c[0, 0] + c[c.nW - 1, c.nK - 1];


      dd = c[1];
      string s = c["Ala ma kota"];
    }
  }
}
