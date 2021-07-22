using Com.Core.ConwayOsler.Interface;


namespace Com.TestData.ConwayOsler.Interface.Page.MyAccount
{
  public class MyAccount : CoreInterface
  {
    public void ClickTShirts(string xpath = "//*[@id=\"block_top_menu\"]/ul/li[3]")
    {
      Client.Actions.Click.ElementXpath(xpath);
    }

    public void WaitForTShirtCategory(string elementClass = "cat-name")
    {
      Client.Actions.Wait.ForClassName(elementClass);
    }
  }
}
