using Com.Test.ConwayOsler.Helper;
using NUnit.Framework;
using static Com.Test.ConwayOsler.Data.Data;

namespace Regression
{
  [Order(7)]
  [TestFixture]
  public class ShippingDetails : Helper
  {
    [TestCase(Description = "Valid Shipping Details")]
    public void ValidShippingDetails()
    {
      Website.Page.Order.Shipping.WaitForShippingPage();
      Website.Page.Order.Shipping.ClickTermsOfServiceCheckBox();
      Website.Page.Order.Shipping.ClickProceedToCheckOut();
    }
  }
}
