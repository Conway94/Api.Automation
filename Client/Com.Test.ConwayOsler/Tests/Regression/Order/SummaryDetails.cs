using Com.Test.ConwayOsler.Helper;
using NUnit.Framework;

namespace Regression
{
  [Order(5)]
  [TestFixture]
  public class SummaryDetails : Helper
  {
    [TestCase(Description = "Valid Summary Details")]
    public void ValidSummaryDetails()
    {
      Website.Page.Order.Summary.WaitForOrderPage();
      Website.Page.Order.Summary.ValidateNumItems("1 Product");
      Website.Page.Order.Summary.ClickProceedToCheckOut();
    }
  }
}
