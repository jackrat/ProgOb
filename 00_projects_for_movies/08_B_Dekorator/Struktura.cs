using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_B_Dekorator
{
  public abstract class Samochod
  {
    public virtual string PodajNazwe()
    {
      return "Samochód";
    }
    public virtual double PodajCene()
    {
      return 0;
    }
  }



  public class Ford : Samochod
  {
    public override string PodajNazwe()
    {
      return "Ford";
    }
    public override double PodajCene()
    {
      return 50000;
    }
  }


  public class Peugot : Samochod
  {
    public override string PodajNazwe()
    {
      return "Peugot";
    }
    public override double PodajCene()
    {
      return 60000;
    }
  }



  public abstract class Dekorator : Samochod
  {
    public Samochod pojazd;
  }


  public class Klima : Dekorator
  {
    public Klima(Samochod aPojazd)
    {
      pojazd = aPojazd;
    }

    public override string PodajNazwe()
    {
      return pojazd.PodajNazwe() + " z klimatyzacją";
    }

    public override double PodajCene()
    {
      return pojazd.PodajCene() + 7000;
    }
  }

  public class Metalik : Dekorator
  {
    public Metalik(Samochod aPojazd)
    {
      pojazd = aPojazd;
    }

    public override string PodajNazwe()
    {
      return pojazd.PodajNazwe() + " z lakierem metalic";
    }

    public override double PodajCene()
    {
      return pojazd.PodajCene() + 2000;
    }

  }


  public class Zimowki : Dekorator
  {
    public Zimowki(Samochod aPojazd)
    {
      pojazd = aPojazd;
    }

    public override string PodajNazwe()
    {
      return pojazd.PodajNazwe() + " z kompletem opon zimowych";
    }

    public override double PodajCene()
    {
      return pojazd.PodajCene() + 1500;
    }

  }

}
