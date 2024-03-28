using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_1_Properties
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Przyklad prz = new Przyklad();
      prz.N = 123;
      MessageBox.Show($"Wartość właściwości N: {prz.N}");

    }

    private void button2_Click(object sender, EventArgs e)
    {
      Przyklad prz = new Przyklad();
      //set jest niedozwolony
      //prz.M = 123;
      prz.SetM(123);
      MessageBox.Show($"Wartość właściwości N: {prz.M}");
      prz.SetM(124);
      MessageBox.Show($"Wartość właściwości N: {prz.M}");

    }

    private void button3_Click(object sender, EventArgs e)
    {
      Przyklad prz = new Przyklad();      
      prz.M2 = 123;
      MessageBox.Show($"Wartość właściwości N: {prz.M2}");
      try
      {
        prz.M2 = 124;
      }
      catch { 
        
      }
      MessageBox.Show($"Wartość właściwości N: {prz.M2}");
    }


   
  }
}
