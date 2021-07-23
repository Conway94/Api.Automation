using Com.Test.ConwayOsler.Helper;
using NUnit.Framework;

namespace Regression
{
  [Order(4)]
  [TestFixture]
  public class Shopping : Helper
  {
    [TestCase(Description = "Valid Order T-Shirt")]
    public void ValidOrder()
    {
      Website.Page.Home.ClickTShirts();
      Website.Page.Home.WaitForTShirtCategory();
      Website.Page.Shopping.TShirts.ClickFadedShortSleeveTShirt();
      Website.Page.Shopping.TShirts.ClickColor();
      Website.Page.Shopping.ClickAddToCart();
      Website.Page.Shopping.WaitForShoppingCart();
      Website.Page.Shopping.ClickProceedToCheckOut();
    }
  }
}
