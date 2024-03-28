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
  public partial class PredicatesForm : Form
  {
    ProductManager manager;

    public bool Predicate_PriceMoreThan50(Product p)
    {
      return p.Price > 50;
    }

    public bool Predicate_PriceBeetween40and60(Product p)
    {
      return p.Price >= 40 && p.Price <= 60;
    }

    public PredicatesForm(ProductManager manager)
    {
      InitializeComponent();
      this.manager = manager;
      dataGridView1.DataSource = manager.Products;
      manager.ProductsListChanged += Manager_ProductsListChanged;
    }

    private void Manager_ProductsListChanged()
    {
      dataGridView1.DataSource = null;
      dataGridView1.DataSource = manager.Products;
    }


    
    /// ////////////////////////////////////////////////////////////////////////
    // Buttony

    private void btnPriceMoreThan50_Click(object sender, EventArgs e)
    {
      manager.FilterKind = Predicate_PriceMoreThan50;
      dataGridView1.DataSource = manager.FilterIfYouCan();
    }


    private void button2_Click(object sender, EventArgs e)
    {
      manager.FilterKind = Predicate_PriceBeetween40and60;
      dataGridView1.DataSource = manager.FilterIfYouCan();
    }



    private void button1_Click(object sender, EventArgs e)
    {
      dataGridView1.DataSource = manager.Products;
    }
  }




}
