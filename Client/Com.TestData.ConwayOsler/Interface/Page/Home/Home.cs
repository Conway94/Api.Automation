using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Home
{
  public class Home : CoreInterface
  {
    private const string _signIn = "login";
    private const string _tShirt = "//*[@id=\"block_top_menu\"]/ul/li[3]";
    private const string _tShirtCategory = "cat-name";
    private const string _myAccount = "#header > div.nav > div > div > nav > div:nth-child(1) > a";

    public void ClickSignIn(string elementId = _signIn)
    {
      Client.Actions.Click.ElementClass(elementId);
    }

    public void ClickTShirts(string xpath = _tShirt)
    {
      Client.Actions.Click.ElementXpath(xpath);
    }

    public void WaitForTShirtCategory(string elementClass = _tShirtCategory)
    {
      Client.Actions.Wait.ForClassName(elementClass);
    }

    public void ClickMyAccount(string cssSelector = _myAccount)
    {
      Client.Actions.Click.CssSelector(cssSelector);
    }
  }
}
