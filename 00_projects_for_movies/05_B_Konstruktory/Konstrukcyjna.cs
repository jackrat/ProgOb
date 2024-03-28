using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_B_Konstruktory
{
  class Konstrukcyjna
  {
    ~Konstrukcyjna()
    {
    }

    public Konstrukcyjna()
    {
    }

    protected int p1;
    protected int p2;

    public Konstrukcyjna(int initA)
    {
      p1 = initA;
    }

    //wariant 1
    //public Konstrukcyjna(int initA, int initB)
    //{
    //  p1 = initA;
    //  p2 = initB;
    //}

    public Konstrukcyjna(int initA, int initB)
      : this(initA)
    {
      p2 = initB;
    }

  }


  //konstruktorów się nie dziedziczy!!!

  class KonstrukcyjnaB : Konstrukcyjna
  {
    //public KonstrukcyjnaB(int iii) { }

    protected int p3;


    //wariant 1
    //public KonstrukcyjnaB(int ap1, int ap2, int ap3)
    //{
    //  p1 = ap1;
    //  p2 = ap2;
    //  p3 = ap3;
    //}


    public KonstrukcyjnaB(int ap1, int ap2, int ap3)
      : base(ap1, ap2)
    {
      p3 = ap3;
    }

  }


  

}





