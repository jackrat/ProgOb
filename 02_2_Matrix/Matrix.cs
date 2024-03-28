using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_2_Matrix
{
  internal class Matrix
  {
    public double[,] Tab;

    public Matrix Dodaj(Matrix B)
    {
      Matrix C = new Matrix();
      C.Init(Tab.GetLength(0), Tab.GetLength(1));
      for (int i = 0; i < Tab.GetLength(0); i++)
        for (int j = 0; j < Tab.GetLength(1); j++)
          C.Tab[i, j] = Tab[i, j] + B.Tab[i, j];
      return C;
    }

    Random rnd = new Random();

    public void Init(int iw, int ik)
    {
      Tab = new double[iw, ik];
      for (int i = 0; i < iw; i++)
        for (int j = 0; j < ik; j++)
          Tab[i, j] = rnd.Next(50);
    }

    public string JakoStr()
    {
      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < Tab.GetLength(0); i++)
      {
        for (int j = 0; j < Tab.GetLength(1); j++)
          sb.Append($" {Tab[i, j],5}");
        sb.Append("\r\n");
      }
      return sb.ToString();
    }


    public static Matrix operator +(Matrix m1, Matrix m2)
    {
      return m1.Dodaj(m2);
    }

  }
}
