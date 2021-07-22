using Com.Test.ConwayOsler.Helper;
using NUnit.Framework;

namespace Regression
{
  [Order(5)]
  [TestFixture]
  public class ShoppingCart : Helper
  {
    [TestCase(Description = "Valid Verify Order")]
    public void ValidOrderShirt()
    {
      //Validate Shopping Cart
      Website.Page.ShoppingCart.WaitForShoppingCartPage();
      Website.Page.ShoppingCart.ValidateNumItems("1");
      Website.Page.ShoppingCart.ValidateProductName("Faded Short Sleeve T-shirts");
      Website.Page.ShoppingCart.ValidateInStock();
      Website.Page.ShoppingCart.ClickProceedToCheckOut();
    }
  }
}
