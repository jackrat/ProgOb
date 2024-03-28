using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_A_Interfejsy
{
  public interface IOsoba
  {
    int ID { get; set; }
    string Imie { get; set; }
    string Nazw { get; set; }
    DateTime DataUr { get; set; }
    string Wizytowka();
    bool CzyPelnoletni();
  }
}
