using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_1_TestKontrolek
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnOblicz_Click(object sender, EventArgs e)
    {
      double a = double.Parse(tbA.Text);
      double b = double.Parse(tbB.Text);
      double c = double.Parse(tbC.Text);

      double delta = b * b - 4 * a * c;
      //if (delta < 0)
      //  label1.Text = "Brak rozwiązań!\r\n(delta = "+ delta.ToString() +")";
      if (delta < 0)
        label1.Text = $"Brak rozwiązań!\r\n(delta = {delta})";
      else if (delta == 0)
        label1.Text = $"Jedno rozwiązanie: x0 = {-b / (2 * a)}";
      else
      {
        double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
        label1.Text = $"Dwa rozwiązania:\r\n    x1 = {x1}\r\n   x2 = {x2}";
      }
    }
  }
}
