using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Statyczne
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show(Robocza.Met1());
    }

    private void button2_Click(object sender, EventArgs e)
    {
      //nie można tworzyć instancji klas statycznych
      //Robocza rob = new Robocza();
      //nie można użyć skł. statycznego w odniesieniu do instancji danej klasy
      //rob.Met1();
    }
  }
}
