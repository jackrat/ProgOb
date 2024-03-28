using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_1_ProbyKontrolek
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int n = int.Parse(tbRozmiar.Text);
      int[,] T = new int[n, n];
      for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
          T[i, j] = (i + 1) * (j + 1);
      string s = "";
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < n; j++)
          //s = s + " " + T[i, j].ToString();
          s = $"{s} {T[i,j],3}";
        s = s + "\r\n";
      }

      label1.Text = s;
      textBox1.AppendText("\r\n=======================================================================================\r\n");
      textBox1.AppendText(s);

    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (checkBox1.Checked)
      {
        textBox1.AppendText("\r\n=======================================================================================\r\n");
        textBox1.AppendText((string)listBox1.SelectedItem);
      }
      else 
      {
        textBox1.AppendText("\r\n=======================================================================================\r\n");
        textBox1.AppendText(comboBox1.Text);
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      textBox1.AppendText ($"\r\n{DateTime.Now:HH:mm:ss}");
    }

    private void button3_Click(object sender, EventArgs e)
    {
      DateTime t1 = dateTimePicker1.Value;
      DateTime t2 = DateTime.Now;
      TimeSpan w = t2 - t1;
      label1.Text = $"Wiek Jana Kowalskiego: {w.TotalDays/365:f1} lat";
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      checkBox1.Text = listBox1.SelectedItem.ToString();
    }
  }
}
