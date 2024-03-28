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
  public partial class ComparisonForm : Form
  {

    private ProductManager manager;


    public ComparisonForm(ProductManager manager)
    {
      InitializeComponent();
      this.manager = manager;
      dataGridView1.DataSource = manager.Products;
      manager.ProductsListChanged += ProductsChanged;
      this.FormClosed += ComparisonForm_FormClosed;
    }

    private void ComparisonForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      manager.ProductsListChanged -= ProductsChanged;
    }

    private void ProductsChanged()
    {
      dataGridView1.DataSource = null;
      dataGridView1.DataSource = manager.Products;
    }

    private void btnComp1_Click(object sender, EventArgs e)
    {
      manager.SortKind = Comparizons.byNameComparizon;
      manager.SortIfYouCan();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      manager.SortKind = Comparizons.byDescriptionComparizon;
      manager.SortIfYouCan();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      manager.SortKind = Comparizons.byProductionComparizon;
      manager.SortIfYouCan();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      manager.SortKind = Comparizons.byPriceComparizon;
      manager.SortIfYouCan();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      manager.SortKind = Comparizons.byNameAndPriceComparizon;
      manager.SortIfYouCan();
    }
  }
}
