using C_Delegacje_predefiniowane;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using _11_LINQ;
using System.Collections.Generic;

namespace _11_LINQ
{
  public partial class Form1 : Form
  {

    private ProductManager manager;

    public Form1()
    {
      InitializeComponent();
      manager = new ProductManager();
      manager.RefillProducts(30);
      manager.ProductsListChanged += ListChanged;
      dataGridView1.DataSource = manager.Products;
    }

    private void ListChanged()
    {
      dataGridView1.DataSource = null;
      dataGridView1.DataSource = manager.Products;
    }

    private void button10_Click(object sender, EventArgs e)
    {
      manager.RefillProducts(30);
    }


    //produkty oryginalne
    private void button2_Click(object sender, EventArgs e)
    {
      dataGridView1.DataSource = manager.Products;
    }


    //using System.Linq;
    //extensions
    /////////////////////////////////////////////////////////////////////////////////////
    private void button12_Click(object sender, EventArgs e)
    {
      string s1 = "ala ma kota";
      string s2 = s1.First22Upper();
      MessageBox.Show(s2);
    }


    // alternatywne składnie    
    //filtrowanie: produkty o cenie powyżej 50
    private void button1_Click(object sender, EventArgs e)
    {
      //var col =
      //from Product p in manager.Products
      //where p.Price < 50
      //select p;
      //dataGridView1.DataSource = col.ToList();

      dataGridView1.DataSource = manager.Products.Where(p => p.Price < 50).ToList();


      /*
        
       (x, y, z) => 
       {
         //...
         //...
         int res = x + y + z;
         return res;
       } 

      //////////////

       (x) => 
       {
         //...
         //...
         int res = x * 123;
         return res;
       } 

       x => 
       {
         //...
         //...
         int res = x * 123;
         return res;
       } 

       x => 
       { 
         return x * 123;
       }
       


       x => x * 123
        
        
      */

    }

    //sortowanie: produkty posortowane wg Name
    private void button3_Click(object sender, EventArgs e)
    {
      dataGridView1.DataSource = manager.Products.OrderBy(p => p.Name).ToList();
    }

    //sortowanie: produkty posortowane wg Name i Price
    private void button7_Click(object sender, EventArgs e)
    {
      dataGridView1.DataSource = manager.Products.OrderBy(p => p.Name).ThenBy(p => p.Price).ToList();
    }

    //konwersja: Produkt na CatalogItem
    private void button4_Click(object sender, EventArgs e)
    {
      dataGridView1.DataSource = manager.Products.Select(p =>
        new CatalogItem()
        {
          Caption = p.Name,
          Symbol = p.Code,
          PriceRange = p.Price < 40 ? "tani" : p.Price > 70 ? "drogi" : "średni"
        })
      .ToList();

    }

    //grupowanie wg pierwszej litery Name, konwersja do klasy anonimowej, obliczanie średniej ceny i sortowanie
    private void button5_Click(object sender, EventArgs e)
    {
      dataGridView1.DataSource = manager.Products
        .GroupBy(p => p.Name[0])                                                             //pogrupowanie wg pierwszej litery nazy
        .Select(g => new { Lit = g.Key, Avg = g.Average(p => p.Price), Count = g.Count() }) //konwersja ononimowej klasy z kluczem i średnią ceną dla każdej grupy
        .OrderBy(a => a.Lit)                                                                 //posortowanie Lit, czyli wg klucza grupy  
        .ToList();
    }

    //wyszukanie produktu/produtów o maksymalnej cenie
    private void button6_Click(object sender, EventArgs e)
    {
      // to działa:
      //       dataGridView1.DataSource = coll.Where(p => p.Price == coll.Max(a => a.Price)).ToList(); 
      // jak i to:
      //        dataGridView1.DataSource = coll.OrderByDescending(p => p.Price).Take(1).ToList();
      // ale lepiej tak:
      double mx = manager.Products.Max(p => p.Price);
      dataGridView1.DataSource = manager.Products.Where(p => p.Price == mx).ToList();
    }

    //unikalne nazwy produktów posortowane i przekonwertowane do klasy anonimowej
    private void button8_Click(object sender, EventArgs e)
    {
      dataGridView1.DataSource = manager.Products
        .Select(p => p.Name)
        .Distinct()
        .OrderBy(s => s)
        .Select(s => new { Name = s })
        .ToList();
    }

    //odwrócenie kolejności
    private void button9_Click(object sender, EventArgs e)
    {
      //dataGridView1.DataSource = manager.Products.AsEnumerable().Reverse().ToList();
      dataGridView1.DataSource = (dataGridView1.DataSource as IEnumerable<Product>).Reverse().ToList();
    }


    //wyraźny kod imperatywny
    private void button11_Click(object sender, EventArgs e)
    {
      dataGridView1.DataSource = manager.Products.Where(
        p =>
        {
          if (p.Price > 50)
            return true;
          else
            if (p.Name.StartsWith("A") || p.Name.StartsWith("C") || p.Name.StartsWith("Z"))
            return true;
          else
            return false;
        })
        .ToList();
    }


  }
}
