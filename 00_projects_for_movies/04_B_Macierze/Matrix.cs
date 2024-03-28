using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Macierze
{
  class Matrix
  {
    public int nW;
    public int nK;

    public double[,] Values;//można private

    public double this[int w1, int w2]
    {
      get { return Values[w1, w2]; }
      set { Values[w1, w2] = value; }
    }

    public double this[int w1]
    {
      get { return Values[w1, 0]; }
      set { Values[w1, 0] = value; }
    }

    public string this[string w1]
    {
      get { return w1 + " " + Values[0, 0].ToString(); }
      set { Values[0, 0] = double.Parse(value); }
    }


    public Matrix(int iW, int iK)
    {
      nW = iW;
      nK = iK;
      Values = new double[nW, nK];
    }

    public Matrix Dodaj(Matrix B)
    {
      Matrix C = new Matrix(nW, nK);
      for (int i = 0; i < nW; i++)
        for (int j = 0; j < nK; j++)
          C.Values[i, j] = Values[i, j] + B.Values[i, j];
      return C;
    }


    static Random rnd = new Random();
    public void Losuj()
    {
      for (int i = 0; i < nW; i++)
        for (int j = 0; j < nK; j++)
          Values[i, j] = rnd.Next(100);
    }

    public string AsString
    {
      get
      {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < nW; i++)
        {
          for (int j = 0; j < nK; j++)
            sb.Append(string.Format("{0,5}", Values[i, j]));
          sb.AppendLine();
        }
        return sb.ToString();
      }
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
      return m1.Dodaj(m2);
    }


  }
}
