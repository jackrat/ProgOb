using _2020_05_23._24_E_Thread_Pool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_B4_Thread_Pool
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    TableProvider tp1, tp2, tp3;
    Director d1, d2, d3;




    private void button1_Click(object sender, EventArgs e)
    {
      tp1 = new TableProvider();
      tp1.tableLen = (int)numericUpDown1.Value;
      tp1.tableCount = (int)numericUpDown2.Value;
      tp1.Prepare();
      tp2 = new TableProvider(tp1);
      tp3 = new TableProvider(tp1);

      d1 = new Director(tp1);
      d1.ThreadsCount = (int)numericUpDown3.Value;
      d2 = new Director(tp2);
      d2.ThreadsCount = d1.ThreadsCount;
      d3 = new Director(tp3);
      d3.ThreadsCount = d1.ThreadsCount;


      d1.Init(); d1.button = button2;
      d2.Init(); d2.button = button3;
      d3.Init(); d3.button = button4;

      d1.Koniec += D1_Koniec;
      d2.Koniec += D2_Koniec;
      d3.Koniec += D3_Koniec;

      button2.Text = "";
      button3.Text = "";
      button4.Text = "";
    }



    private void button2_Click(object sender, EventArgs e)
    {
      d1.StartWithNewThreads();
    }


    private void button3_Click(object sender, EventArgs e)
    {
      d2.StartWithThreadPool();
    }



    private void button4_Click(object sender, EventArgs e)
    {
      d3.StartWithNewTasks();
    }


    private void D1_Koniec(object sender, EventArgs e)
    {
      button2.Invoke(new Action(delegate () { button2.Text = (sender as Director).Duration.TotalSeconds.ToString("F3") + " s"; }));
    }


    private void D2_Koniec(object sender, EventArgs e)
    {
      button3.Invoke(new Action(delegate () { button3.Text = (sender as Director).Duration.TotalSeconds.ToString("F3") + " s"; }));
    }
    private void D3_Koniec(object sender, EventArgs e)
    {
      button4.Invoke(new Action(delegate () { button4.Text = (sender as Director).Duration.TotalSeconds.ToString("F3") + " s"; }));
    }
  }
}
