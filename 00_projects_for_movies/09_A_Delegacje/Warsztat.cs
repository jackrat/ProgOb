using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_A_Delegacje
{
  class Warsztat
  {
    public void RobotaProc(string s, double x, delegacjaDoPracyProc tool)
    {
      if (tool != null)
        tool(s, x);

      // tool?.Invoke(s, x);
    }

    public string RobotaFun(string s, double x, delegacjaDoPracyFun tool)
    {
      return tool?.Invoke(s, x);

      //składnia alternatywna
      //if (tool != null)
      //  return tool(s, x);
      //else
      //  return null;
    }
  }
}
