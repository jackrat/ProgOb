using System;
using System.Threading;
using System.Windows.Forms;

namespace _08_B3_Threads_Efficiency
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    DateTime t1; //czas rozpoczęcia 
    DateTime t2; //czas zakończenia

    int m = 5000;  // rozmiar sortowanych tablic (do zmieniania)
    int nt = 10;     // ilość tablic do sortowania (do zmieniania)

    double[][] tabele1; // tablice do sortowania jednowątkowego
    double[][] tabele2; // tablice do sortowania wielowątkowego


    private void button1_Click(object sender, EventArgs e)
    {
      label1.Text = "?";
      label2.Text = "?";
      Random rnd = new Random();
      tabele1 = new double[nt][];
      tabele2 = new double[nt][];
      for (int i = 0; i < nt; i++)
      {
        tabele1[i] = new double[m];
        tabele2[i] = new double[m];
        for (int j = 0; j < m; j++)
        {
          tabele1[i][j] = 100 * rnd.NextDouble();
          tabele2[i][j] = tabele1[i][j];
        }
      }
    }


    void showing(Label l)
    {
      l.Text = string.Format("{0} ms", (t2 - t1).TotalMilliseconds);
    }


    void sorter(double[] tab)
    {
      int n = tab.Length;
      bool bylo;
      do
      {
        bylo = false;
        for (int i = 1; i < n; i++)
          if (tab[i - 1] > tab[i])
          {
            double m = tab[i - 1];
            tab[i - 1] = tab[i];
            tab[i] = m;
            bylo = true;
          }
      } while (bylo);
    }


    private void thrsorter(object obj)
    {
      sorter(obj as double[]);
      t2 = DateTime.Now;
      label2.Invoke(new Action(delegate () { showing(label2); }));
    }


    private void button2_Click(object sender, EventArgs e)
    {
      t1 = DateTime.Now;
      for (int i = 0; i < nt; i++)
        sorter(tabele1[i]);
      t2 = DateTime.Now;
      showing(label1);
    }


    private void button3_Click(object sender, EventArgs e)
    {
      t1 = DateTime.Now;
      for (int i = 0; i < nt; i++)
      {
        Thread thr = new Thread(thrsorter);
        thr.Start(tabele2[i]);
      }
    }

    


  }
}
