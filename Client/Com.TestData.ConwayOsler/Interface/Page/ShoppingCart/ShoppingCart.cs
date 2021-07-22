using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.ShoppingCart
{
  public class ShoppingCart : CoreInterface
  {
    public void WaitForShoppingCartPage(string elementId = "cart_title")
    {
      Client.Actions.Wait.ForElementId(elementId);
    }

    public void ValidateNumItems(string numItems, string elementId = "summary_products_quantity")
    {
      Client.Actions.Text.ValidateId(elementId, numItems);
    }

    public void ValidateProductName(string productName = "", string elementClass = "product-name")
    {
      Client.Actions.Text.ValidateClass(elementClass, productName);
    }

    public void ValidateInStock(string inStock = "In Stock", string elementClass = "cart_avail")
    {
      Client.Actions.Text.ValidateClass(elementClass, inStock);
    }

    public void ClickProceedToCheckOut(string xpath = "//*[@id=\"center_column\"]/p[2]/a[1]")
    {
      Client.Actions.Click.ElementXpath(xpath);
    }
  }
}
