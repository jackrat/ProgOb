using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_A_Refleksje
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }


    //to trafia nie wiadomo skąd - brak dostępu do definicji
    object o = new Tajemnicza();

    private void button1_Click(object sender, EventArgs e)
    {
      Type t = o.GetType();
      PropertyInfo[] pros = t.GetProperties();
      MethodInfo[] metody = t.GetMethods();

      listBox1.DataSource = pros;
      listBox2.DataSource = metody;


    }

    private void button3_Click(object sender, EventArgs e)
    {
      Type t = o.GetType();
      MethodInfo metinf = listBox2.SelectedItem as MethodInfo;
      t.InvokeMember(metinf.Name, BindingFlags.InvokeMethod, null, o, null);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Type t = o.GetType();
      MethodInfo metinf = listBox2.SelectedItem as MethodInfo;
      object r = t.InvokeMember(metinf.Name, BindingFlags.InvokeMethod, null,
        o, new object[] { new int[] { 11, 13, 17 } });

      string res = (string)r;
      MessageBox.Show(res);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Type t = o.GetType();
      PropertyInfo propStr = listBox1.Items[0] as PropertyInfo;
      PropertyInfo propDecArr = listBox1.Items[1] as PropertyInfo;

      t.InvokeMember("Show", BindingFlags.InvokeMethod, null, o, null);

      t.InvokeMember(propStr.Name, BindingFlags.SetProperty, null,
        o, new object[] { "Ala ma kota" });

      t.InvokeMember(propDecArr.Name, BindingFlags.SetProperty, null,
        o, new object[] { new decimal[] { 233, 455, 666, 999 } });

      t.InvokeMember("Show", BindingFlags.InvokeMethod, null, o, null);

    }
  }
}
