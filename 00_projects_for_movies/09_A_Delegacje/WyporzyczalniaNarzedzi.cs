using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_A_Delegacje
{
  class WyporzyczalniaNarzedzi
  {
    public static void narz1_Proc(string s1, double d2)
    {
      MessageBox.Show("Wykonuje się metoda narz1_Proc()\r\nTekst: " + s1 + d2.ToString());
    }

    public static string narz2_Fun(string s1, double d2)
    {
      return "Tekst opracowano w metodzie narz2_Fun()\r\nTekst: " + s1 + d2.ToString();
    }


    public void narz3_Proc(string s123, double d444)
    {
      MessageBox.Show("Wykonuje się metoda narz3_Proc()\r\n" + s123 + d444.ToString());
    }

    public string narz4_Fun(string s123, double d444)
    {
      return "Tekst opracowano w metodzie narz4_Fun()\r\nTekst: " + s123 + d444.ToString();
    }
  }
}
