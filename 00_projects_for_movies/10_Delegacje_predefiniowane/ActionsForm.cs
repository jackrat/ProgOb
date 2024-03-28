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
  public partial class ActionsForm : Form
  {
    public ActionsForm(ProductManager manager)
    {
      InitializeComponent();
      this.manager = manager;
      dataGridView1.DataSource = manager.Products;
      manager.ProductsListChanged += Manager_ProductsListChanged;
      FormClosed += ActionsForm_FormClosed;
    }

    private void ActionsForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      manager.ProductsListChanged -= Manager_ProductsListChanged;
    }

    private void Manager_ProductsListChanged()
    {
      dataGridView1.DataSource = null;
      dataGridView1.DataSource = manager.Products;
    }

    ProductManager manager;


    dChangeByRatio delChangeByRatio;
    dChangeByTimeSpan delChangeByTimeSpan;
    dChangeByRelation delChangeByRelation;


    Action<Product, double> actChangeByRatio;
    Action<Product, TimeSpan> actChangeByTimeSpan;
    Action<Product, Product> actChangeByRelation;


    private void btnChangeByRatio_Click(object sender, EventArgs e)
    {
      if (delChangeByRatio != null)
      {
        Product p = dataGridView1.CurrentRow.DataBoundItem as Product;
        delChangeByRatio(p, 10);
        dataGridView1.Refresh();
      }
    }

    private void btnChangeByTimeSpan_Click(object sender, EventArgs e)
    {
      if (delChangeByTimeSpan != null)
      {
        Product p = dataGridView1.CurrentRow.DataBoundItem as Product;
        delChangeByTimeSpan(p, TimeSpan.FromHours(100));
        dataGridView1.Refresh();
      }
    }

    private void btnChangeByRelation_Click(object sender, EventArgs e)
    {
      if (delChangeByRelation != null && dataGridView1.SelectedRows.Count > 1)
      {
        Product pA = dataGridView1.SelectedRows[0].DataBoundItem as Product;
        Product pB = dataGridView1.SelectedRows[1].DataBoundItem as Product;
        delChangeByRelation(pA, pB);
        dataGridView1.Refresh();
      }
    }

    private void btnPriceGrow_Click(object sender, EventArgs e)
    {
      delChangeByRatio = Actions.PriceGrow;
      actChangeByRatio = Actions.PriceGrow;
    }

    private void btnChangeExpirationByPercent_Click(object sender, EventArgs e)
    {
      delChangeByRatio = Actions.ChangeExpirationByPercent;
      actChangeByRatio = Actions.ChangeExpirationByPercent;
    }

    private void btnChangeProductionDate_Click(object sender, EventArgs e)
    {
      delChangeByTimeSpan = Actions.ChangeProductionDate;
      actChangeByTimeSpan = Actions.ChangeProductionDate;
    }

    private void btnChangeProductionDateRound_Click(object sender, EventArgs e)
    {
      delChangeByTimeSpan = Actions.ChangeProductionDateRound;
      actChangeByTimeSpan = Actions.ChangeProductionDateRound;
    }

    private void btnChangePricesToMax_Click(object sender, EventArgs e)
    {
      delChangeByRelation = Actions.ChangePricesToMax;
      actChangeByRelation = Actions.ChangePricesToMax;
    }

    private void btnChangePricesToAvg_Click(object sender, EventArgs e)
    {
      delChangeByRelation = Actions.ChangePricesToAvg;
      actChangeByRelation = Actions.ChangePricesToAvg;
    }

    private void btnActionChangeByRatio_Click(object sender, EventArgs e)
    {
      if (actChangeByRatio != null)
      {
        Product p = dataGridView1.CurrentRow.DataBoundItem as Product;
        actChangeByRatio(p, 10);
        dataGridView1.Refresh();
      }
    }

    private void btnActionChangeByTimeSpan_Click(object sender, EventArgs e)
    {
      if (actChangeByTimeSpan != null)
      {
        Product p = dataGridView1.CurrentRow.DataBoundItem as Product;
        actChangeByTimeSpan(p, TimeSpan.FromHours(100));
        dataGridView1.Refresh();
      }
    }

    private void btnActionChangeByRelation_Click(object sender, EventArgs e)
    {
      if (actChangeByRelation != null && dataGridView1.SelectedRows.Count > 1)
      {
        Product pA = dataGridView1.SelectedRows[0].DataBoundItem as Product;
        Product pB = dataGridView1.SelectedRows[1].DataBoundItem as Product;
        actChangeByRelation(pA, pB);
        dataGridView1.Refresh();
      }
    }
  }
}
