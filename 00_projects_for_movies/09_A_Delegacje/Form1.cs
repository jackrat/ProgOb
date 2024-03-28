using _09_A_Delegacje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_A_Delegacje
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }


    procedure proc;

    void proc1()
    {
      MessageBox.Show("Witaj świecie!");
    }
    void proc2()
    {
      MessageBox.Show("Papa!");
    }


    private void button10_Click(object sender, EventArgs e)
    {
      proc = proc1;
      //proc = new procedure(proc1); //składnia alternatywna
    }

    private void button11_Click(object sender, EventArgs e)
    {
      proc = proc2;
      //proc = new procedure(proc2); //składnia alternatywna
    }

    private void button12_Click(object sender, EventArgs e)
    {
      if (proc != null) proc();
      //proc?.Invoke(); //alternatywna równowazna składnia
    }





    delegate void myDelegate();
    myDelegate deleg;

    void metoda_1()
    {
      MessageBox.Show("Wykonuje się metoda_1()");
    }

    void metoda_2()
    {
      MessageBox.Show("Wykonuje się metoda_2()");
    }

    
    
    



    delegacjaDoPracyProc delProc;
    delegacjaDoPracyFun delFun;
    Warsztat w = new Warsztat();

    private void button4_Click(object sender, EventArgs e)
    {
      delProc = WyporzyczalniaNarzedzi.narz1_Proc;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      WyporzyczalniaNarzedzi wn = new WyporzyczalniaNarzedzi();
      delProc = wn.narz3_Proc;
    }

    private void button6_Click(object sender, EventArgs e)
    {
      w.RobotaProc(" Ładna pogoda ", 25.7, delProc);
    }

    private void button7_Click(object sender, EventArgs e)
    {
      delFun = WyporzyczalniaNarzedzi.narz2_Fun;
    }

    private void button8_Click(object sender, EventArgs e)
    {
      WyporzyczalniaNarzedzi wn = new WyporzyczalniaNarzedzi();
      delFun = wn.narz4_Fun;
    }

    private void button9_Click(object sender, EventArgs e)
    {
      string s = w.RobotaFun("Brzydka pogoda", 3.5, delFun);
      MessageBox.Show(s);
    }


  }
}
