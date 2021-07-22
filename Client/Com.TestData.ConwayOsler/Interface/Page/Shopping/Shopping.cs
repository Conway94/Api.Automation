using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Shopping
{
  public class Shopping : CoreInterface
  {
    public TShirts.TShirts TShirts = new TShirts.TShirts();

    public void ClickAddToCart(string elementId = "add_to_cart")
    {
      Client.Actions.Click.ElementId(elementId);
    }

    public void WaitForShoppingCart(string elementClass = "clearfix")
    {
      Client.Actions.Wait.ForClassName(elementClass);
    }

    public void ClickProceedToCheckOut(string xpath = "//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a")
    {
      Client.Actions.Click.ElementXpath(xpath);
    }
  }
}
