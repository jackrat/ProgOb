using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Delegacje_predefiniowane
{
  public class ProductManager
  {
    public event Action ProductsListChanged;


    public List<Product> Products
    {
      get { return products; }
    }
    private List<Product> products = new List<Product>();



    public void RefillProducts(int witCount)
    {
      products.Clear();
      FactoryOfProducts.AddToListRandomProducts(products, witCount);

      if (ProductsListChanged != null)
        ProductsListChanged();
    }


    //////////////////////////////////////////////////////////////

      
    //FILTROWANIE (predykaty)

    public Predicate<Product> FilterKind;

    public List<Product> FilterIfYouCan()
    {
      if (FilterKind != null)
      {
        List<Product> res = new List<Product>();

        foreach (Product p in Products)
          if (FilterKind(p))
            res.Add(p);
        return res;

      }
      return null;
    }

    //KONWERTOWANIE => strig (konwertery)

    public Converter<Product, string> Converter2String;

    public List<string> Convert2String()
    {
      List<string> res = null;
      if (Converter2String != null)
      {
        res = new List<string>();
        foreach (Product p in Products)
          res.Add(Converter2String(p));
      }
      return res;
    }


    //KONWERTOWANIE => CatalogItem  (konwertery)

    public Converter<Product, CatalogItem> Converter2CatalogItem;

    public List<CatalogItem> Convert2CatalogItem()
    {
      List<CatalogItem> res = null;
      if (Converter2CatalogItem != null)
      {
        res = new List<CatalogItem>();
        foreach (Product p in Products)
          res.Add(Converter2CatalogItem(p));
      }
      return res;
    }


    //SORTOWANIE (comparison)

    public Comparison<Product> SortKind;

    public void SortIfYouCan()
    {
      if (SortKind != null)
      {
        products.Sort(SortKind);

        if (ProductsListChanged != null)
          ProductsListChanged();
      }
    }

  }
}
