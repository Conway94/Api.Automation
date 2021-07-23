using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Home
{
  public class Home : CoreInterface
  {
    private const string _signInButton = "login";
    private const string _tShirtButton = "//*[@id=\"block_top_menu\"]/ul/li[3]";
    private const string _tShirtCategoryField = "cat-name";
    private const string _myAccountButton = "#header > div.nav > div > div > nav > div:nth-child(1) > a";

    public void ClickSignIn(string elementId = _signInButton)
    {
      Client.Actions.Click.ElementClass(elementId);
    }

    public void ClickTShirts(string xpath = _tShirtButton)
    {
      Client.Actions.Click.ElementXpath(xpath);
    }

    public void WaitForTShirtCategory(string elementClass = _tShirtCategoryField)
    {
      Client.Actions.Wait.ForClassName(elementClass);
    }

    public void ClickMyAccount(string cssSelector = _myAccountButton)
    {
      Client.Actions.Click.CssSelector(cssSelector);
    }
  }
}
