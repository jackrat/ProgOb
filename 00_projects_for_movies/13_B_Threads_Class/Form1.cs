using System;
using System.Threading;
using System.Windows.Forms;

namespace _08_B2_Threads_Class
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    void showTime()
    {
      textBox1.AppendText(DateTime.Now.ToString() + "\r\n");
    }


    void robota()
    {
      for (int i = 0; i < 10; i++)
      {
        Thread.Sleep(500);
        textBox1.Invoke(new Action(showTime));
      }
    }


    private void button1_Click(object sender, EventArgs e)
    {
      Thread thr = new Thread(robota);
      thr.Start();
    }


    void robota2(object par)
    {
      int n = (int)par;
      for (int i = 0; i < n; i++)
      {
        Thread.Sleep(500);
        textBox1.Invoke(new Action(showTime));
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Thread thr = new Thread(robota2);
      thr.Start(3);
    }



    void robota3(object par)
    {
      int[] tn = (int[])par;
      int s = 0;
      for (int i = 0; i < tn[0]; i++)
      {
        Thread.Sleep(500);
        textBox1.Invoke(new Action(showTime));
        s += 3;
      }
      tn[1] = s;
      textBox1.Invoke(new Action(koniec));
    }



    int[] dane;
    Thread thr3;

    private void button3_Click(object sender, EventArgs e)
    {
      dane = new int[2];
      dane[0] = 10;
      thr3 = new Thread(robota3);
      thr3.Priority = ThreadPriority.Lowest;
      thr3.Start(dane);
      //thr3.Start(new int[] { 123, 56 });
    }



    void koniec()
    {
      textBox1.AppendText(string.Format("wynik: {0}\r\n", dane[1]));
    }



    private void button4_Click(object sender, EventArgs e)
    {
      if (thr3 != null)// && thr3.ThreadState == ThreadState.Running)
        thr3.Abort();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      //if (thr3 != null && thr3.ThreadState == ThreadState.Running)
      thr3.Suspend();
    }

    private void button6_Click(object sender, EventArgs e)
    {
      //if (thr3 != null && thr3.ThreadState == ThreadState.Suspended)
      thr3.Resume();
    }
  }
}
