using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_05_23._24_E_Thread_Pool
{
  class TableProvider
  {
    public int tableLen;
    public int tableCount;

    public List<double[]> Tables { get; private set; }


    private static Random rnd = new Random();

    public void Prepare()
    {
      if (tableCount > 0 && tableLen > 0)
      {
        Tables = new List<double[]>();

        while (Tables.Count < tableCount)
        {
          double[] t = new double[tableLen];
          for (int i = 0; i < tableLen; i++)
            t[i] = 100 * rnd.NextDouble();
          Tables.Add(t);
        }
      }
    }


    public TableProvider() { }
    public TableProvider(TableProvider copyFrom)
    {
      tableLen = copyFrom.tableLen;
      tableCount = copyFrom.tableCount;
      Tables = new List<double[]>();
      foreach (double[] t in copyFrom.Tables)
      {
        double[] t2 = new double[t.Length];
        Tables.Add(t2);
        t.CopyTo(t2, 0);

      }
    }
  }
}
