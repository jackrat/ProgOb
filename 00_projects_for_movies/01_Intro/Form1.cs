using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Intro
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //MessageBox.Show("!!!!!!!Witaj świecie!!!");
      DialogResult res = openFileDialog1.ShowDialog();
      if (res == DialogResult.OK)
        textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
    }

    private void button1_MouseEnter(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      label1.Text = "Hello world! " + DateTime.Now.ToString();
      textBox1.Text = label1.Text;
    }

    private void comboBox1_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        string s = comboBox1.Text;
        comboBox1.Items.Add(s);
      }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      string s = (string)listBox1.Items[listBox1.SelectedIndex];
      textBox1.Text = textBox1.Text + "\r\n" + s;
      MessageBox.Show(s);
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      if (radioButton1.Checked)
        this.BackColor = Color.Red;
      else if (radioButton2.Checked)
        this.BackColor = Color.Green;
      else if (radioButton3.Checked)
        this.BackColor = Color.Blue;
      else
        this.BackColor = Color.White;
    }
  }
}
