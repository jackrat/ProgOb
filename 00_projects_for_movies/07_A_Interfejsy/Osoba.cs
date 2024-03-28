using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_A_Interfejsy
{
  public class Osoba : IOsoba
  {
    public int ID { get; set; }
    public string Imie { get; set; }
    public string Nazw { get; set; }
    public DateTime DataUr { get; set; }
    public bool CzyPelnoletni()
    {
      return (DateTime.Now - DataUr).TotalDays / 365.25 > 18;
    }
    public string Wizytowka()
    {
      string s = CzyPelnoletni() ? "dorosły" : "małolat";
      return $"{Imie} {Nazw}\r\n{DataUr:yyyy-MM-dd}\r\n{s}";
    }

    public DateTime KiedyUrodziny()
    {
      DateTime dt0 = new DateTime(DateTime.Now.Year, DataUr.Month, DataUr.Day);
      if (DateTime.Now < dt0)
        return dt0;
      else
        return dt0.AddYears(1);
    }
  }
}
