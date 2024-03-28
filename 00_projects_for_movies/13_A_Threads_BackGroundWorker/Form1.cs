using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_B1_Threads_BackGroundWorker
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    bool STOP;

    private void button1_Click(object sender, EventArgs e)
    {
      STOP = false;
      int n = 100;
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < n; i++)
      {
        string s = string.Format("{0:HH:mm:ss} iteracja: {1}", DateTime.Now, i);
        sb.AppendLine(s);
        Text = s;
        progressBar1.Value = 100 * i / n;
        Thread.Sleep(100);
        Application.DoEvents();
        if (STOP)
          break;
      }
      textBox1.Text = sb.ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      STOP = true;
    }

    string msg;

    void showTxt()
    {
      Text = msg;
    }



    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      int n = 100;
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < n; i++)
      {
        string s = string.Format("{0:HH:mm:ss} iteracja: {1}", DateTime.Now, i);
        sb.AppendLine(s);
        //tak nie można
        //Text = s;    
        //trzeba tak    
        msg = s;
        this.Invoke(new Action(showTxt));




        backgroundWorker1.DoWork += (a, b) =>
        {
          //...
          textBox1.AppendText("abcdefgh\r\n");
          //...
        };

        backgroundWorker1.DoWork += (a, b) =>
        {
          //...
          textBox1.Invoke(new Action(() => textBox1.AppendText("abcdefgh\r\n")));
          //...
        };

        Action action = new Action(() => textBox1.AppendText("abcdefgh\r\n"));
        backgroundWorker1.DoWork += (c, v) =>
        {
          //...
          textBox1.Invoke(action);
          //...
        };

        Action addLiner = () => textBox1.AppendText("abcdefgh\r\n");
        backgroundWorker1.DoWork += (c, v) =>
        {
          //...
          textBox1.Invoke(addLiner);
          //...
        };

        //tak nie można
        //progressBar1.Value = 100 * i / n;
        //tak można
        backgroundWorker1.ReportProgress(100 * i / n);

        Thread.Sleep(100);
        if (backgroundWorker1.CancellationPending)
        {
          e.Cancel = true;
          break;
        }
      }
      if (!e.Cancel)
        e.Result = sb.ToString();

      /*
      /////////////////////////////////////////////////////////
      volatile bool stop = false;
      /////////////////////////////////////////////////////
      while (!false)
      {
        //...
        //...
        Thread.Sleep(100);
        if (stop)
        {
          e.Cancel = true;
          break;
        }
      }
      //////////////////////////////////////////////////////////
      */
    }


    private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      progressBar1.Value = e.ProgressPercentage;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      backgroundWorker1.RunWorkerAsync();
    }

    private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      string s = "KONIEC";
      if (e.Error != null)
      {
        s += "\r\nBŁĄD\r\n" + e.Error.Message;
      }
      if (e.Cancelled)
      {
        s += "\r\nPRZERWANO przez usera";
      }

      if (!e.Cancelled && e.Error == null && e.Result != null)
      {
        //s += "\r\n" + e.Result.ToString();
        textBox1.Text = (string)e.Result;
      }
      MessageBox.Show(s);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      backgroundWorker1.CancelAsync();
    }


  }
}
