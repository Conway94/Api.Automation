using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Order.Shipping
{
  public class Shipping : CoreInterface
  {
    private const string _shippingPage = "#order_step > li.step_current.four";
    private const string _termsOfServiceCheckBox = "checker";
    private const string _proceedToCheckOut = "//*[@id=\"form\"]/p/button";

    public void WaitForShippingPage(string cssSelector = _shippingPage)
    {
      Client.Actions.Wait.ForCssSelector(cssSelector);
    }

    public void ClickTermsOfServiceCheckBox(string elementClass = _termsOfServiceCheckBox)
    {
      Client.Actions.Click.ElementClass(elementClass);
    }

    public void ClickProceedToCheckOut(string xpath = _proceedToCheckOut)
    {
      Client.Actions.Click.ElementXpath(xpath);
    }
  }
}
