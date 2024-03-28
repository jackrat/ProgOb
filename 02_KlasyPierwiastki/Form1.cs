using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_KlasyPierwiastki
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double a = double.Parse(textBox1.Text);
      double b = double.Parse(textBox2.Text);
      double c = double.Parse(textBox3.Text);
      double delta = b * b - 4 * a * c;
      if (delta < 0)
        label1.Text = "Brak rozwiazań";
      else if (delta == 0)
      {
        double x0 = -b / (2 * a);
        label1.Text = $"x0 = {x0}";
      }
      else
      {
        double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        label1.Text = $"x1 = {x1}\r\nx2 = {x2}";
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      PierwiastkiA pA = new PierwiastkiA();
      pA.a = double.Parse(textBox1.Text);
      pA.b = double.Parse(textBox2.Text);
      pA.c = double.Parse(textBox3.Text);
      pA.Oblicz();
      label1.Text = pA.WynikJakoStr();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      PierwiastkiA pA = new PierwiastkiA();
      pA.setA(textBox1.Text); 
      pA.setB(textBox2.Text);
      pA.setC(textBox3.Text);
      pA.Oblicz();
      label1.Text = pA.WynikJakoStr();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      PierwiastkiA pA = new PierwiastkiA();
      pA.setABC(textBox1.Text, textBox2.Text, textBox3.Text);
      pA.Oblicz();
      label1.Text = pA.WynikJakoStr();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      PierwiastkiA pA = new PierwiastkiA(textBox1.Text, textBox2.Text, textBox3.Text);
      pA.Oblicz();
      label1.Text = pA.WynikJakoStr();
    }
  }
}
