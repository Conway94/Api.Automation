using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Order.Summary
{
  public class Summary : CoreInterface
  {
    private const string _orderPage = "#order_step > li.step_current.first";
    private const string _productQuantity = "#summary_products_quantity";
    private const string _proceedToCheckout = "#center_column > p.cart_navigation.clearfix > a.button.btn.btn-default.standard-checkout.button-medium";

    public void WaitForOrderPage(string cssSelector = _orderPage)
    {
      Client.Actions.Wait.ForCssSelector(cssSelector);
    }

    public void ValidateNumItems(string numItems, string cssSelector = _productQuantity)
    {
      Client.Actions.Text.ValidateCssSelector(cssSelector, numItems);
    }

    public void ClickProceedToCheckOut(string cssSelector = _proceedToCheckout)
    {
      Client.Actions.Click.CssSelector(cssSelector);
    }
  }
}
