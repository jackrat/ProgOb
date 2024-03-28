using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_2_Matrix
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    Matrix A, B, C;

   

    private void button1_Click(object sender, EventArgs e)
    {
      A = new Matrix();
      A.Init(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
      label1.Text = A.JakoStr();
    }

    

    private void button2_Click(object sender, EventArgs e)
    {
      B = new Matrix();
      B.Init(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
      label2.Text = B.JakoStr();
    }

    

    private void button3_Click(object sender, EventArgs e)
    {
      C = A.Dodaj(B);
      label3.Text = C.JakoStr();
    }

    

    private void button4_Click(object sender, EventArgs e)
    {
      C = A + B;
      label3.Text= C.JakoStr();
    }


    private void button5_Click(object sender, EventArgs e)
    {
      BackColor = Color.Black;
      label1.ForeColor = Color.Green;
      label2.ForeColor = Color.Green;
      label3.ForeColor = Color.Green;
      timer1.Enabled = !timer1.Enabled;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      A.Init(50,6);
      label1.Text = A.JakoStr();
      A.Init(50, 6);
      label2.Text = B.JakoStr();
      C = A + B;
      label3.Text = C.JakoStr();
    }
  }
}
