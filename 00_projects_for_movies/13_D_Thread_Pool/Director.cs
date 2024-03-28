using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020_05_23._24_E_Thread_Pool
{
  class Director
  {
    public System.Windows.Forms.Button button;
    private TableProvider provider;
    public int ThreadsCount;

    public Director(TableProvider aProvider)
    {
      provider = aProvider;
    }

    public DateTime t1;
    public DateTime t2;

    private int toSort;
    private int workingThreads;

    public void Init()
    {
      toSort = provider.tableCount;
      workingThreads = ThreadsCount;
    }


    private readonly object locker = new object();

    public event EventHandler Koniec;




    public double[] Next()
    {
      lock (locker)
      {
        if (toSort == provider.tableCount)
          t1 = DateTime.Now;

        if (toSort > 0)
          return provider.Tables[--toSort];
        else
        {
          workingThreads--;
          if (workingThreads == 0)
          {
            t2 = DateTime.Now;
            Koniec?.Invoke(this, null);
          }
          return null;
        }
      }
    }



    public TimeSpan Duration { get { return t2 - t1; } }



    public void StartWithNewThreads()
    {
      for (int i = 0; i < ThreadsCount; i++)
      {
        Thread thr = new Thread(Sorter.robota);
        thr.Start(this);
      }
    }


    public void StartWithThreadPool()
    {
      for (int i = 0; i < ThreadsCount; i++)
      {
        ThreadPool.QueueUserWorkItem(Sorter.robota, this);
      }
    }


    internal void StartWithNewTasks()
    {
      for (int i = 0; i < ThreadsCount; i++)
      {
        Task.Run((() => Sorter.robota(this)));
      }
    }


  }

}