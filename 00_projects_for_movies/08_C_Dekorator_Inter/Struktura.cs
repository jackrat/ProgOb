using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_C_Dekorator_Inter
{

  public interface ISamochod
  {
    string PodajNazwe();
    double PodajCene();
  }



  public class Ford : ISamochod
  {
    public string PodajNazwe()
    {
      return "Ford";
    }
    public double PodajCene()
    {
      return 50000;
    }
  }


  public class Peugot : ISamochod
  {
    public string PodajNazwe()
    {
      return "Peugot";
    }
    public double PodajCene()
    {
      return 60000;
    }
  }



  public interface IDekorator : ISamochod
  {
    ISamochod pojazd { get; set; }
  }


  public class Klima : IDekorator
  {
    public ISamochod pojazd { get; set; }

    public Klima(ISamochod aPojazd)
    {
      pojazd = aPojazd;
    }

    public string PodajNazwe()
    {
      return pojazd.PodajNazwe() + " z klimatyzacją";
    }

    public double PodajCene()
    {
      return pojazd.PodajCene() + 7000;
    }
  }

  public class Metalik : IDekorator
  {
    public ISamochod pojazd { get; set; }

    public Metalik(ISamochod aPojazd)
    {
      pojazd = aPojazd;
    }

    public string PodajNazwe()
    {
      return pojazd.PodajNazwe() + " z lakierem metalic";
    }

    public double PodajCene()
    {
      return pojazd.PodajCene() + 2000;
    }

  }


  public class Zimowki : IDekorator
  {
    public ISamochod pojazd { get; set; }

    public Zimowki(ISamochod aPojazd)
    {
      pojazd = aPojazd;
    }

    public string PodajNazwe()
    {
      return pojazd.PodajNazwe() + " z kompletem opon zimowych";
    }

    public double PodajCene()
    {
      return pojazd.PodajCene() + 1500;
    }

  }

}
