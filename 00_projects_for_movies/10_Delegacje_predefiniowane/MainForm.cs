using System;
using System.Windows.Forms;

namespace C_Delegacje_predefiniowane
{
  public partial class MainForm : Form
  {

    private ProductManager manager = new ProductManager();

    public MainForm()
    {
      InitializeComponent();
      manager.ProductsListChanged += ListChanged;
      FormClosed += MainForm_FormClosed;
      manager.RefillProducts(30);
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      manager.ProductsListChanged -= ListChanged;
    }

    private void ListChanged()
    {
      dataGridView1.DataSource = null;
      dataGridView1.DataSource = manager.Products;
    }


    
    ////////////////////////////////////////////////////////////////
    //  Buttony
    

    private void button1_Click(object sender, EventArgs e)
    {
      manager.RefillProducts(30);
    }

    private void btnComparison_Click(object sender, EventArgs e)
    {
      (new ComparisonForm(manager)).Show();
    }

    private void btnActions_Click(object sender, EventArgs e)
    {
      (new ActionsForm(manager)).Show();
    }

    private void btnFuncs_Click(object sender, EventArgs e)
    {
      (new FuncsForm(manager)).Show();
    }

    private void btnPredicates_Click(object sender, EventArgs e)
    {
      (new PredicatesForm(manager)).Show();
    }

    private void btnConverters_Click(object sender, EventArgs e)
    {
      (new ConvertersForm(manager)).Show();
    }
    

   

  }
}
