using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Order.Payment
{
  public class Payment : CoreInterface
  {
    private const string _paymentPage = "#step_end";
    private const string _payByBankWireButton = "bankwire";
    private const string _bankWirePaymentPage = "page-subheading";
    private const string _confirmOrderButton = "#cart_navigation > button";
    private const string _orderComplete = "#center_column > div > p > strong";

    public void WaitForPaymentPage(string cssSelector = _paymentPage)
    {
      Client.Actions.Wait.ForCssSelector(cssSelector);
    }

    public void ClickPayByBankWire(string elementClass = _payByBankWireButton)
    {
      Client.Actions.Click.ElementClass(elementClass);
    }

    public void ValidateBankWirePage(string text = "BANK-WIRE PAYMENT.", string elementClass = _bankWirePaymentPage)
    {
      Client.Actions.Text.ValidateClass(elementClass, text);
    }

    public void ClickConfirmOrder(string cssSelector = _confirmOrderButton)
    {
      Client.Actions.Click.CssSelector(cssSelector);
    }

    public void ValidateOrderComplete(string text = "Your order on My Store is complete.",
      string cssSelector = _orderComplete)
    {
      Client.Actions.Text.ValidateCssSelector(cssSelector, text);
    }
  }
}
