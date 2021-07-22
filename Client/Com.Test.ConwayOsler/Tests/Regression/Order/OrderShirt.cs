using Com.Test.ConwayOsler.Helper;
using NUnit.Framework;

namespace Regression
{
  [Order(4)]
  [TestFixture]
  public class OrderShirt : Helper
  {
    [TestCase(Description = "Valid Order T-Shirt")]
    public void ValidOrderShirt()
    {
      //Order Shirt
      Website.Page.MyAccount.ClickTShirts();
      Website.Page.MyAccount.WaitForTShirtCategory();
      Website.Page.Shopping.TShirts.ClickFadedShortSleeveTShirt();
      Website.Page.Shopping.TShirts.ClickColor();
      Website.Page.Shopping.ClickAddToCart();
      Website.Page.Shopping.WaitForShoppingCart();
      Website.Page.Shopping.ClickProceedToCheckOut();
    }
  }
}
