using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_1_Pierwiastki_A
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
        label1.Text = "Brak rozwiązań!";
      else
        if (delta == 0)
      {
        double x0 = -b / (2 * a);
        label1.Text = "x0 = " + x0.ToString();
      }
      else
      {
        double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        label1.Text = string.Format("x1 = {0}\r\nx2 = {1}",
          x1, x2);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      PierwiastkiA pA = new PierwiastkiA();
      //pA.setA(textBox1.Text);
      //pA.setB(textBox2.Text);
      //pA.setC(textBox3.Text);
      pA.setABC(textBox1.Text, textBox2.Text, textBox3.Text);
      pA.Oblicz();
      if (pA.wynik.Length == 0)
        label1.Text = "Brak rozwiązań!";
      else
      if (pA.wynik.Length == 1)
        label1.Text = string.Format("x0 = {0}", pA.wynik[0]);
      else
        label1.Text = string.Format("x1 = {0}\r\nx2 = {1}", pA.wynik[0], pA.wynik[1]);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      PierwiastkiA pA = new PierwiastkiA(textBox1.Text, textBox2.Text, textBox3.Text);
      if (pA.wynik.Length == 0)
        label1.Text = "Brak rozwiązań!";
      else
       if (pA.wynik.Length == 1)
        label1.Text = string.Format("x0 = {0}", pA.wynik[0]);
      else
        label1.Text = string.Format("x1 = {0}\r\nx2 = {1}", pA.wynik[0], pA.wynik[1]);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      PierwiastkiA pA = new PierwiastkiA(textBox1.Text, textBox2.Text, textBox3.Text);
      label1.Text = pA.WynikAsString();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      PierwiastkiA pA = new PierwiastkiA(textBox1.Text, textBox2.Text, textBox3.Text);
      pA.szab0 = "-";
      pA.szab1 = "Jedno rozwiązanie: ";
      pA.szab2 = "Dwa rozwiązania: {0}  oraz  {1}";
      label1.Text = pA.WynikAsString2();
    }

    PierwiastkiA pB = new PierwiastkiA();

    private void button6_Click(object sender, EventArgs e)
    {
      pB.setABC(textBox1.Text, textBox2.Text, textBox3.Text);
      pB.Oblicz();
      label1.Text = pB.WynikAsString2();
    }
  }
}
