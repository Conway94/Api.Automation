using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Shopping
{
  public class Shopping : CoreInterface
  {
    private const string _addToCartButton = "add_to_cart";
    private const string _shoppingCartPopUp = "clearfix";
    private const string _proceedToCheckoutButton = "//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a";

    public TShirts.TShirts TShirts = new TShirts.TShirts();

    public void ClickAddToCart(string elementId = _addToCartButton)
    {
      Client.Actions.Click.ElementId(elementId);
    }

    public void WaitForShoppingCart(string elementClass = _shoppingCartPopUp)
    {
      Client.Actions.Wait.ForClassName(elementClass);
    }

    public void ClickProceedToCheckOut(string xpath = _proceedToCheckoutButton)
    {
      Client.Actions.Click.ElementXpath(xpath);
    }
  }
}
