using _08_D_Dekoratory_adv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_D_Dekoratory_adv
{
  public partial class Form1 : Form
  {

    Samochod ford = new Ford();

    public Form1()
    {
      InitializeComponent();
    }

    void przedstaw()
    {
      label1.Text = ford.PodajNazwe();
      label2.Text = ford.PodajCene().ToString();

    }

    private void button1_Click(object sender, EventArgs e)
    {
      switch (listBox1.SelectedIndex)
      {
        case 0: ford = Klima.Udekoruj(ford); break;
        case 1: ford = Metalik.Udekoruj(ford); break;
        case 2: ford = Zimowki.Udekoruj(ford); break;
      }
      przedstaw();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      switch (listBox1.SelectedIndex)
      {
        case 0: ford = Klima.Oddekoruj(ford); break;
        case 1: ford = Metalik.Oddekoruj(ford); break;
        case 2: ford = Zimowki.Oddekoruj(ford); break;
      }
      przedstaw();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      switch (listBox1.SelectedIndex)
      {
        case 0: ford = Dekorator.Oddekoruj2(ford, typeof(Klima)); break;
        case 1: ford = Dekorator.Oddekoruj2(ford, typeof(Metalik)); break;
        case 2: ford = Dekorator.Oddekoruj2(ford, typeof(Zimowki)); break;
      }
      przedstaw();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      switch (listBox1.SelectedIndex)
      {
        case 0: ford = ford.Udekoruj3(typeof(Klima)); break;
        case 1: ford = ford.Udekoruj3(typeof(Metalik)); break;
        case 2: ford = ford.Udekoruj3(typeof(Zimowki)); break;
      }
      przedstaw();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      switch (listBox1.SelectedIndex)
      {
        case 0: ford = ford.Udekoruj3(typeof(Klima)); break;
        case 1: ford = ford.Udekoruj3(typeof(Metalik)); break;
        case 2: ford = ford.Udekoruj3(typeof(Zimowki)); break;
      }
      przedstaw();
    }

    private void button6_Click(object sender, EventArgs e)
    {
      switch (listBox1.SelectedIndex)
      {
        case 0: ford = ford.Oddekoruj3(typeof(Klima)); break;
        case 1: ford = ford.Oddekoruj3(typeof(Metalik)); break;
        case 2: ford = ford.Oddekoruj3(typeof(Zimowki)); break;
      }
      przedstaw();
    }
  }
}
