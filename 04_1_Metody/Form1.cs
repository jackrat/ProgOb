using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_1_Metody
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    Robo r = new Robo();

    private void button1_Click(object sender, EventArgs e)
    {
      int i = 123;
      string s = "Ala ma kota";
      bool b = false;
      //MessageBox.Show($"Przed Met01: i: {i}  s: {s}  b: {b}");
      r.Met01(i, s, b);
      MessageBox.Show($"Po Met01: i: {i}  s: {s}  b: {b}");
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int i = 123;
      string s = "Ala ma kota";
      bool b = false;
      MessageBox.Show($"Przed Met02: i: {i}  s: {s}  b: {b}");
      r.Met02(ref i, ref s, ref b);
      MessageBox.Show($"Po Met02: i: {i}  s: {s}  b: {b}");
    }

    private void button3_Click(object sender, EventArgs e)
    {
      int i = 123;
      string s = "Ala ma kota";
      bool b = false;
      MessageBox.Show($"Przed Met03: i: {i}  s: {s}  b: {b}");
      r.Met03(out i, out s, out b);
      MessageBox.Show($"Po Met03: i: {i}  s: {s}  b: {b}");
    }

    private void button4_Click(object sender, EventArgs e)
    {
      double[] d = new double[10];
      d[0] = Math.PI;
      Class1 c = new Class1();
      c.d = DateTime.Now;
      c.t = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      c.S = "Ala ma kota";
      DateTime dt = new DateTime(2025, 1, 1);
      MessageBox.Show($"Przed Met04: d[0]: {d[0]}  c.t[0]: {c.t[0]} c.d: {c.d} dt: {dt}");
      r.Met04(d, c, dt);
      MessageBox.Show($"Po Met04: d[0]: {d[0]}  c.t[0]: {c.t[0]} c.d: {c.d} dt: {dt}");
    }

    private void button5_Click(object sender, EventArgs e)
    {
      double[] d = new double[10];
      d[0] = Math.PI;
      Class1 c = new Class1();
      c.d = DateTime.Now;
      c.t = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      c.S = "Ala ma kota";
      DateTime dt = new DateTime(2025, 1, 1);
      MessageBox.Show($"Przed Met05: d[0]: {d[0]}  c.t[0]: {c.t[0]} c.d: {c.d} dt: {dt}");
      r.Met05(ref d, ref c, ref dt);
      MessageBox.Show($"Po Met05: d[0]: {d[0]}  c.t[0]: {c.t[0]} c.d: {c.d} dt: {dt}");
    }

    private void button6_Click(object sender, EventArgs e)
    {
      double r = 100;
      double P = Robo.ObliczPiRKwadrat(r);
      MessageBox.Show($"Pole okręgu o promieniu {r}: {P}");

      //Robo.metodaStat(0, 0, "", DateTime.Now, new decimal[] { 325, 2356, 21354 }, new Class1());
    }

    private void button7_Click(object sender, EventArgs e)
    {
      string s = "Ala ma kota";
      s = s.Bez3PierwszychiOstatnich();
      MessageBox.Show(s);

      Class1 c = new Class1();
      c.d = DateTime.Now;

      MessageBox.Show($"{Ext.DodajDoDtDni(c.d, 3)}");
      MessageBox.Show($"{c.DodajDoDtDni(3)}");

    }

    private void button8_Click(object sender, EventArgs e)
    {
      //Class2 c2 = new Class2();

      //Class2 c2b = new Class2("Ala ma kota...", new DateTime(1999,1,1), null, 667);

      Class2 c2c = new Class2("Ala ma kota...", new DateTime(1999, 1, 1), null, 667, 1975);
    }
  }
}
