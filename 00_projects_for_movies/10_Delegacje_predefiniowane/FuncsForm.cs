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
  public partial class FuncsForm : Form
  {

    ProductManager manager;

    public FuncsForm(ProductManager manager)
    {
      InitializeComponent();
      this.manager = manager;
      dataGridView1.DataSource = manager.Products;
      manager.ProductsListChanged += Manager_ProductsListChanged;
      FormClosed += FuncsForm_FormClosed;
    }

    private void FuncsForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      manager.ProductsListChanged -= Manager_ProductsListChanged;
    }

    private void Manager_ProductsListChanged()
    {
      dataGridView1.DataSource = null;
      dataGridView1.DataSource = manager.Products;
    }

    Func<IEnumerable<Product>, double> funcSomePrices;
    Func<Product, Product, int> copp;

    int fff(Product x, Product y)
    {
      return 0;
    }

    
    private void btbAvgPrice_Click(object sender, EventArgs e)
    {


      copp = fff;
      manager.Products.Sort(fff);


      funcSomePrices = Functions.AvgPriceFromProducts;
    }

    private void btnAvgCheapPrices_Click(object sender, EventArgs e)
    {
      funcSomePrices = Functions.AvgPriceFromCheapProducts;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (funcSomePrices != null && dataGridView1.SelectedRows.Count > 0)
      {
        Product[] selP = new Product[dataGridView1.SelectedRows.Count];
        int i = 0;
        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
          selP[i++] = row.DataBoundItem as Product;
        double d = funcSomePrices(selP);
        MessageBox.Show("Funkcja " + funcSomePrices.ToString() + " policzyła średnią cenę: " + d.ToString());
      }
      else
        MessageBox.Show("Brak zaznaczonych obiektów");
    }
  }
}
