using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_A_Interfejsy
{
  public class Uczen : Osoba
  {
    public string NrLegSzk { get; set; }
    new public string Wizytowka()
    {
      //można tak:
      //return base.Wizytowka()+$"\r\nLeg: {NrLegSzk}";
      //albo tak:
      return (this as Osoba).Wizytowka()+$"\r\nLeg: {NrLegSzk}";

    }
  }
}
