using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_05_23._24_E_Thread_Pool
{
  class Sorter
  {

    static void sorter(double[] tab)
    {
      int n = tab.Length;
      bool bylo;
      do
      {
        bylo = false;
        for (int i = 1; i < n; i++)
          if (tab[i - 1] > tab[i])
          {
            double m = tab[i - 1];
            tab[i - 1] = tab[i];
            tab[i] = m;
            bylo = true;
          }
      } while (bylo);
    }



    public static void robota(object ob)
    {
      Director dir = ob as Director;
      double[] t;
      int jj = 0;
      do
      {
        t = dir.Next();
        jj++;

        if (t != null)
        {
          dir.button.Invoke(new Action(() => { dir.button.Text = "Next " + jj; }));
          sorter(t);
        }
      } while (t != null);
    }


  }
}
