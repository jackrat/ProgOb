using _02_1_Pierwiastki_A;
using System;
using System.Windows.Forms;

namespace _03_Propertisy
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      
    }

    PierwiastkiA pC = new PierwiastkiA();
    private void button1_Click(object sender, EventArgs e)
    {
      pC.setABC(textBox1.Text, textBox2.Text, textBox3.Text);
      pC.Oblicz();
      label1.Text = pC.WynikAsString2();
    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {
      if (double.TryParse(textBox4.Text, out double x))
        pC.a = x;
      if (double.TryParse(textBox5.Text, out double y))
        pC.b = y;
      if (double.TryParse(textBox6.Text, out double z))
        pC.c = z;
      pC.Oblicz();
      label2.Text = pC.WynikAsString();
    }


    PierwiastkiB pBBB = new PierwiastkiB();



    private void button2_Click(object sender, EventArgs e)
    {
      textBox7.DataBindings.Add("Text", pBBB, "A", false, DataSourceUpdateMode.OnPropertyChanged);
      textBox8.DataBindings.Add("Text", pBBB, "B", false, DataSourceUpdateMode.OnPropertyChanged);
      textBox9.DataBindings.Add("Text", pBBB, "C", false, DataSourceUpdateMode.OnPropertyChanged);
      label3.DataBindings.Add("Text", pBBB, "WynikStr", false, DataSourceUpdateMode.OnPropertyChanged);
    }

    Random rnd = new Random();

    private void button3_Click(object sender, EventArgs e)
    {
      pBBB.A = 1 + rnd.Next(1000);
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
      Form1 f = new Form1();
      f.pBBB = pBBB;
      f.Show();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      button2_Click(null, null);
    }
  }
}
