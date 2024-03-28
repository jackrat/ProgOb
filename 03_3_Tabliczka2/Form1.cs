using _03_2_Tabliczka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_3_Tabliczka2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      tab = new Tabliczka2();
      tbCol1.DataBindings.Add("Text", tab, "Col1", false, DataSourceUpdateMode.OnPropertyChanged);
      tbCol2.DataBindings.Add("Text", tab, "Col2", false, DataSourceUpdateMode.OnPropertyChanged);
      tbRow1.DataBindings.Add("Text", tab, "Row1", false, DataSourceUpdateMode.OnPropertyChanged);
      tbRow2.DataBindings.Add("Text", tab, "Row2", false, DataSourceUpdateMode.OnPropertyChanged);
      label1.DataBindings.Add("Text", tab, "Wynik", false, DataSourceUpdateMode.OnPropertyChanged);
    }

    Tabliczka2 tab;

    private void button1_Click(object sender, EventArgs e)
    {
      tab.Col1 = 5;
    }
  }
}
