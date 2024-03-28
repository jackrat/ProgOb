using _08_C_Dekorator_Inter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_C_Dekorator_Inter
{
  public partial class Form1 : Form
  {
    ISamochod ford;
    ISamochod peugot;

    public Form1()
    {
      InitializeComponent();
      ford = new Ford();
      peugot = new Peugot();
      przedstaw();
    }

    void przedstaw()
    {
      label1.Text = ford.PodajNazwe();
      label2.Text = ford.PodajCene().ToString();
      label3.Text = peugot.PodajNazwe();
      label4.Text = peugot.PodajCene().ToString();
    }

    private void btnAddKlimaToFord_Click(object sender, EventArgs e)
    {
      ford = new Klima(ford);
      przedstaw();
    }

    private void btnAddMetalicToFord_Click(object sender, EventArgs e)
    {
      ford = new Metalik(ford);
      przedstaw();
    }

    private void btnDelKlimaFromFord_Click(object sender, EventArgs e)
    {
      if (ford is Klima)
        ford = (ford as Klima).pojazd;
      przedstaw();
    }

    private void btnDelMetalicFromFord_Click(object sender, EventArgs e)
    {
      if (ford is Metalik)
        ford = (ford as Metalik).pojazd;
      przedstaw();
    }

    private void btnAddKlimaToPeugot_Click(object sender, EventArgs e)
    {
      peugot = new Klima(peugot);
      przedstaw();
    }

    private void btnAddMetalicToPeugot_Click(object sender, EventArgs e)
    {
      peugot = new Metalik(peugot);
      przedstaw();
    }

    private void btnDelKlimaFromPeugot_Click(object sender, EventArgs e)
    {
      if (peugot is Klima)
        peugot = (peugot as Klima).pojazd;
      przedstaw();
    }

    private void btnDelMetalicFromPeugot_Click(object sender, EventArgs e)
    {
      if (peugot is Metalik)
        peugot = (peugot as Metalik).pojazd;
      przedstaw();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (ford is IDekorator)
        ford = (ford as IDekorator).pojazd;
      przedstaw();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (peugot is IDekorator)
        peugot = (peugot as IDekorator).pojazd;
      przedstaw();
    }

    private void btnAddZimowkiToFord_Click(object sender, EventArgs e)
    {
      ford = new Zimowki(ford);
      przedstaw();
    }

    private void btnDelZimowkiFromFord_Click(object sender, EventArgs e)
    {
      if (ford is Zimowki)
        ford = (ford as Zimowki).pojazd;
      przedstaw();
    }
  }
}
