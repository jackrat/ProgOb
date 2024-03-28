using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Delegacje_predefiniowane
{
  public partial class ConvertersForm : Form
  {
    ProductManager manager;



    public ConvertersForm(ProductManager manager)
    {
      InitializeComponent();
      this.manager = manager;
      dataGridView1.DataSource = manager.Products;
    }


    private void button1_Click(object sender, EventArgs e)
    {
      listBox1.BringToFront();
      manager.Converter2String = Converters.ToNameAndDescr20;
      dataGridView1.DataSource = null;
      listBox1.DataSource = manager.Convert2String();      
    }

    private void button2_Click(object sender, EventArgs e)
    {
      dataGridView1.BringToFront();
      manager.Converter2CatalogItem = Converters.ToCatalogItem;
      dataGridView1.DataSource = manager.Convert2CatalogItem();
      listBox1.DataSource = null;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      dataGridView1.BringToFront();
      dataGridView1.DataSource = manager.Products;
      listBox1.DataSource = null;
    }
  }

  class Converters
  {
    public static string ToNameAndDescr20(Product p)
    {
      return p.Name + " ++++++  " + p.Description.Substring(0, 20);
    }

    public static CatalogItem ToCatalogItem(Product p)
    {
      CatalogItem res = new CatalogItem();
      res.Symbol = p.Code;
      res.Caption = p.Name;
      if (p.Price < 50)
        res.PriceRange = "Low";
      else if (p.Price > 100)
        res.PriceRange = "High";
      else
        res.PriceRange = "Average";
      return res;
    }
  }

}
