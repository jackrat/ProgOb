using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Metody
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      A oA = new A();
      string s = oA.Met1("Ala ma kota");
      oA.Met1("Kot ma Alę");
      oA.Met1();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string s = "Hey-ho!";
      A oA = new A();
      MessageBox.Show($"s przed: {s}");
      oA.Met1(s);
      MessageBox.Show($"s po: {s}");
    }

    private void button3_Click(object sender, EventArgs e)
    {
      string s = "Hey-ho!";
      A oA = new A();
      MessageBox.Show($"s przed: {s}");
      oA.Met1(ref s);
      MessageBox.Show($"s po: {s}");


      string s2;
      //tak nie, bo s2 nie jest zainicjowane
      //oA.Met1(ref s2);
      oA.Met1(out s2, 123);
      oA.Met1(out string s3, 123);
      MessageBox.Show($"s3 po: {s3}");


    }
  }

  class A
  {
    public void Met1()
    {
      MessageBox.Show("Tu Met1!");
    }

    // to za mało żeby odróżnić od tej powyższej
    //public string Met1()
    //{
    //  MessageBox.Show("Tu Met1!");
    //  return "Met1";
    //}

    public string Met1(string s)
    {
      MessageBox.Show("pocz. wywołania \r\n" + s);
      s = "Tu Met1!\r\n" + s;
      MessageBox.Show("koniec wywołania \r\n" + s);
      return s;
    }

    public string Met1(ref string s)
    {
      MessageBox.Show("pocz. wywołania \r\n" + s);
      s = "Tu Met1!\r\n" + s;
      MessageBox.Show("koniec wywołania \r\n" + s);
      return s;
    }


    public void Met1(out string s, int i)
    {
      s = "Tu Met1!\r\n";
     
      MessageBox.Show("koniec wywołania \r\n" + s);

    }


  }


}
