using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_A_Interfejsy
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }


    IOsoba io;

    private void button1_Click(object sender, EventArgs e)
    {
      Osoba o = new Osoba()
      {
        ID = 1,
        Imie = "Jan",
        Nazw = "Kowalski",
        DataUr = new DateTime(1970, 1, 17)
      };

      MessageBox.Show(o.Wizytowka());
      MessageBox.Show(o.KiedyUrodziny().ToString("yyyy-MM-dd"));
    }

    private void button2_Click(object sender, EventArgs e)
    {
      io = new Osoba()
      {
        ID = 2,
        Imie = "Janek",
        Nazw = "Kowal",
        DataUr = new DateTime(2008, 10, 17)
      };
      MessageBox.Show(io.Wizytowka());
      //To jest niedozwolone
      //MessageBox.Show(io.KiedyUrodziny().ToString("yyyy-MM-dd"));
      //ale tak można:
      MessageBox.Show((io as Osoba).KiedyUrodziny().ToString("yyyy-MM-dd"));
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Uczen u = new Uczen()
      {
        ID = 3,
        Imie = "Katarzyna",
        Nazw = "Kowalska",
        DataUr = new DateTime(2010, 3, 21),
        NrLegSzk = "WL6600123"
      };
      MessageBox.Show(u.Wizytowka());
    }

    private void button4_Click(object sender, EventArgs e)
    {
      io = new Uczen()
      {
        ID = 4,
        Imie = "Izabela",
        Nazw = "Dwernicka",
        DataUr = new DateTime(2011, 1, 1),
        NrLegSzk = "WL6600567"
      };
      MessageBox.Show(io.Wizytowka());
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Student u = new Student()
      {
        ID = 5,
        Imie = "Piotr",
        Nazw = "Zieliński",
        DataUr = new DateTime(2000, 2, 28),
        NrAlbumu = "ALB666"
      };
      MessageBox.Show(u.Wizytowka());
    }

    private void button6_Click(object sender, EventArgs e)
    {
      io = new Student()
      {
        ID = 6,
        Imie = "Piotr",
        Nazw = "Zieliński",
        DataUr = new DateTime(2000, 2, 28),
        NrAlbumu = "ALB666"
      };
      MessageBox.Show(io.Wizytowka());
    }

    

    private void button10_Click(object sender, EventArgs e)
    {
      io = new Osoba()
      {
        ID = 1,
        Imie = "Jan",
        Nazw = "Kowalski",
        DataUr = new DateTime(1970, 1, 17)
      };
    }

    private void button9_Click(object sender, EventArgs e)
    {
      io = new Uczen()
      {
        ID = 3,
        Imie = "Katarzyna",
        Nazw = "Kowalska",
        DataUr = new DateTime(2010, 3, 21),
        NrLegSzk = "WL6600123"
      };
    }

    private void button8_Click(object sender, EventArgs e)
    {
      io = new Student()
      {
        ID = 5,
        Imie = "Piotr",
        Nazw = "Zieliński",
        DataUr = new DateTime(2000, 2, 28),
        NrAlbumu = "ALB666"
      };
    }



    private void button7_Click(object sender, EventArgs e)
    {
      MessageBox.Show(io.Wizytowka());
    }
  }
}
