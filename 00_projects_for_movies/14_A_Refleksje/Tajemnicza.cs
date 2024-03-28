using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_A_Refleksje
{
  public class Tajemnicza
  {

    public Tajemnicza()
    {
      PropPubArrayOfDec = new decimal[0];
      PropPubStr = "empty";
    }

    private int PropPrivInt { get; set; }
    public string PropPubStr { get; set; }
    private List<string> PropPrivLst { get; set; }
    public decimal[] PropPubArrayOfDec { get; set; }


    public void Show()
    {
      string s2 = string.Join(", ", PropPubArrayOfDec);
      string m = $"PropPubStr: {PropPubStr}\r\nPropPubArrayOfDec: {s2}";
      MessageBox.Show(m);
    }

    private void MetPrivVoid()
    {
      MessageBox.Show("Pozdrowienia od MetPrivVoid");
    }

    public void MetPubVoid()
    {
      MessageBox.Show("Pozdrowienia od MetPubVoid");
    }

    Random rnd = new Random();

    public int MetPubInt()
    {
      int i = rnd.Next();
      MessageBox.Show($"Pozdrowienia od MetPubInt!\r\nZaraz zwrócę {i}");
      return i;
    }



    public string MetPubInt(int[] partab)
    {
      string s = string.Join(", ", partab);
      MessageBox.Show(s);
      return s;
    }
  }
}
