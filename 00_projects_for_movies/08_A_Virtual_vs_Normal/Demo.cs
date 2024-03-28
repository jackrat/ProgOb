using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_A_Virtual_vs_Normal
{

  class ClassB
  {
    public void MetodaA() { Console.WriteLine("ClassB.MetodaA()"); }
    public virtual void MetodaB() { Console.WriteLine("ClassB.MetodaB()"); }
  }


  class ClassP1 : ClassB
  {
    new public void MetodaA() { Console.WriteLine("ClassP1.MetodaA()"); }
    public override void MetodaB() { Console.WriteLine("ClassP1.MetodaB()"); }
  }

  class ClassP2 : ClassB
  {
    new public void MetodaA() { Console.WriteLine("ClassP1.MetodaA()"); }
    public override void MetodaB() { Console.WriteLine("ClassP1.MetodaB()"); }
  }


  class u
  {
    public void m_SYM()
    {
      ClassB b = new ClassB();
      b.MetodaA(); // ClassB.MetodaA()
      b.MetodaB(); // ClassB.MetodaB()

      ClassP1 p = new ClassP1();
      p.MetodaA(); // ClassP1.MetodaA()
      p.MetodaB(); // ClassP1.MetodaB()

      //====================================
      (p as ClassB).MetodaA(); // ClassB.MetodaA()
      (p as ClassB).MetodaB(); // ClassP1.MetodaB()

      ((ClassB)p).MetodaA(); // ClassB.MetodaA()
      ((ClassB)p).MetodaB(); // ClassP1.MetodaB()

      int i = 100;
      byte by = 200;
      i = by;
      //by = i;//ŹLE
      //by = i as byte;//Źle
      by = (byte)i;

    }

    public void m_ASYM()
    {
      //ClassP1 p = new ClassB(); // ŹLE!
      //p.MetodaA(); // ------------
      //p.MetodaB(); // ------------

      ClassB b = new ClassP1();
      b.MetodaA(); // ClassB.MetodaA()
      b.MetodaB(); // ClassP1.MetodaB()
    }

  }



}
