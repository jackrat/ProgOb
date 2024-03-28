using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_D_Dekoratory_adv
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

    public Samochod Oddekoruj3(Type typDekoratora)
    {
      Samochod s = this;
      Dekorator d0 = null;
      do
      {
        if (s.GetType() == typDekoratora)
        {
          if (d0 == null)
            return (s as Dekorator).pojazd;
          else
          {
            d0.pojazd = (s as Dekorator).pojazd;
            return this;
          }
        }

        if (s is Dekorator)
        {
          d0 = s as Dekorator;
          s = (s as Dekorator).pojazd;
        }

      } while (s is Dekorator);
      return this;
    }
    internal Samochod Udekoruj3(Type typDekoratora)
    {
      bool mozna = true;
      if (this is Dekorator)
      {
        Samochod s = this;
        do
        {
          if (s.GetType() == typDekoratora)
          {
            mozna = false;
            break;
          }
          else if (s is Dekorator)
            s = (s as Dekorator).pojazd;
          else
            break;
        }
        while (s is Dekorator);
      }
      Samochod res;
      if (mozna)
        res = Activator.CreateInstance(typDekoratora, new object[] { this }) as Samochod;
      else
        res = this;
      return res;
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

    public static Samochod Oddekoruj2(Samochod pojazd, Type typDekoratora)
    {
      Samochod s = pojazd;
      Dekorator d0 = null;
      do
      {
        if (s.GetType() == typDekoratora)
        {
          if (d0 == null)
            return (s as Dekorator).pojazd;
          else
          {
            d0.pojazd = (s as Dekorator).pojazd;
            return pojazd;
          }
        }

        if (s is Dekorator)
        {
          d0 = s as Dekorator;
          s = (s as Dekorator).pojazd;
        }

      } while (s is Dekorator);
      return pojazd;
    }
    internal static Samochod Udekoruj2(Samochod pojazd, Type typDekoratora)
    {
      bool mozna = true;
      if (pojazd is Dekorator)
      {
        Samochod s = pojazd;
        do
        {
          if (s.GetType() == typDekoratora)
          {
            mozna = false;
            break;
          }
          else if (s is Dekorator)
            s = (s as Dekorator).pojazd;
          else
            break;
        }
        while (s is Dekorator);
      }
      Samochod res;
      if (mozna)
        res = Activator.CreateInstance(typDekoratora, new object[] { pojazd }) as Samochod;
      else
        res = pojazd;
      return res;
    }
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

    internal static Samochod Oddekoruj(Samochod pojazd)
    {
      Samochod s = pojazd;
      Dekorator d0 = null;
      do
      {
        if (s is Klima)
        {
          if (d0 == null)
            return (s as Klima).pojazd;
          else
          {
            d0.pojazd = (s as Klima).pojazd;
            return pojazd;
          }
        }

        if (s is Dekorator)
        {
          d0 = s as Dekorator;
          s = (s as Dekorator).pojazd;
        }

      } while (s is Dekorator);
      return pojazd;
    }

    public override double PodajCene()
    {
      return pojazd.PodajCene() + 7000;
    }

    internal static Samochod Udekoruj(Samochod pojazd)
    {
      bool mozna = true;
      if (pojazd is Dekorator)
      {
        Samochod s = pojazd;
        do
        {
          if (s is Klima)
          {
            mozna = false;
            break;
          }
          else if (s is Dekorator)
            s = (s as Dekorator).pojazd;
          else
            break;
        }
        while (s is Dekorator);
      }
      Samochod res;
      if (mozna)
        res = new Klima(pojazd);
      else
        res = pojazd;
      return res;
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


    internal static Samochod Udekoruj(Samochod pojazd)
    {
      bool mozna = true;
      if (pojazd is Dekorator)
      {
        Samochod s = pojazd;
        do
        {
          if (s is Metalik)
          {
            mozna = false;
            break;
          }
          else if (s is Dekorator)
            s = (s as Dekorator).pojazd;
          else
            break;
        }
        while (s is Dekorator);
      }
      Samochod res;
      if (mozna)
        res = new Metalik(pojazd);
      else
        res = pojazd;
      return res;
    }

    internal static Samochod Oddekoruj(Samochod pojazd)
    {
      Samochod s = pojazd;
      Dekorator d0 = null;
      do
      {
        if (s is Metalik)
        {
          if (d0 == null)
            return (s as Metalik).pojazd;
          else
          {
            d0.pojazd = (s as Metalik).pojazd;
            return pojazd;
          }
        }

        if (s is Dekorator)
        {
          d0 = s as Dekorator;
          s = (s as Dekorator).pojazd;
        }

      } while (s is Dekorator);
      return pojazd;
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

    internal static Samochod Oddekoruj(Samochod pojazd)
    {
      Samochod s = pojazd;
      Dekorator d0 = null;
      do
      {
        if (s is Zimowki)
        {
          if (d0 == null)
            return (s as Zimowki).pojazd;
          else
          {
            d0.pojazd = (s as Zimowki).pojazd;
            return pojazd;
          }
        }

        if (s is Dekorator)
        {
          d0 = s as Dekorator;
          s = (s as Dekorator).pojazd;
        }

      } while (s is Dekorator);
      return pojazd;
    }



    internal static Samochod Udekoruj(Samochod pojazd)
    {
      bool mozna = true;
      if (pojazd is Dekorator)
      {
        Samochod s = pojazd;
        do
        {
          if (s is Zimowki)
          {
            mozna = false;
            break;
          }
          else if (s is Dekorator)
            s = (s as Dekorator).pojazd;
          else
            break;
        }
        while (s is Dekorator);
      }
      Samochod res;
      if (mozna)
        res = new Zimowki(pojazd);
      else
        res = pojazd;
      return res;
    }


  }
}


