using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_B_Zdarzenia
{
  public class NowyButton : Button
  {
    public event EventHandler lgClick;
    public event EventHandler ldClick;
    public event EventHandler pgClick;
    public event EventHandler pdClick;

    public NowyButton() : base()
    {
      MouseClick += NowyButton_MouseClick;
      BackColor = Color.Orange;
      Font = new Font("Times New Roman", 20);
      Width = 200;
      Height = 200;
    }

    private void NowyButton_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.X < Width / 2 & e.Y < Height / 2)
        if (lgClick != null)
          lgClick(this, new EventArgs());

      if (e.X < Width / 2 & e.Y >= Height / 2)
        if (ldClick != null)
          ldClick(this, new EventArgs());


      if (e.X >= Width / 2 & e.Y < Height / 2)
        if (pgClick != null)
          pgClick(this, new EventArgs());

      if (e.X >= Width / 2 & e.Y >= Height / 2)
        if (pdClick != null)
          pdClick(this, new EventArgs());
    }
  }
}
