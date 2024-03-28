using _09_B_Zdarzenia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_B_Zdarzenia
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }




    void metoda1(object sender, EventArgs e)
    {
      MessageBox.Show("Wykonuje się metoda1();");
    }

    void metoda2(object sender, EventArgs e)
    {
      MessageBox.Show("Wykonuje się metoda2();");
    }

    private void metoda3(object sender, EventArgs e)
    {
      MessageBox.Show("Wykonuje się metoda3();");
    }




    private void button2_Click(object sender, EventArgs e)
    {
      //button1.Click += metoda1;
      //alternatywna składnia
      button1.Click += new EventHandler(metoda1);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      button1.Click += metoda2;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      button1.Click += metoda3;
    }

    private void button7_Click(object sender, EventArgs e)
    {
      button1.Click -= metoda1;
    }

    private void button6_Click(object sender, EventArgs e)
    {
      button1.Click -= metoda2;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      button1.Click -= metoda3;
    }





    private void button10_Click(object sender, EventArgs e)
    {
      button9.Click += Button9_Click;
    }

    private void Button9_Click(object sender, EventArgs e)
    {
      //
      //
    }





    private void button8_Click(object sender, EventArgs e)
    {
      NowyButton btn = new NowyButton();
      this.Controls.Add(btn);
      btn.Left = 300;
      btn.Top = 250;
      btn.Text = "Nowy button ABC";

      btn.lgClick += Btn_lgClick;
      btn.pdClick += Btn_pdClick;
      btn.ldClick += nowyButton1_ldClick;
    }

    

    private void Btn_pdClick(object sender, EventArgs e)
    {
      MessageBox.Show("Trafiłeś PD");
    }

    private void Btn_lgClick(object sender, EventArgs e)
    {
      MessageBox.Show("Trafiłeś LG");
    }

    private void nowyButton1_ldClick(object sender, EventArgs e)
    {
      MessageBox.Show("LD");
    }

   
  }
}
