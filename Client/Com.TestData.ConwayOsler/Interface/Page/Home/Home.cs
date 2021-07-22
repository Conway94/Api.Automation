using Com.Core.ConwayOsler.Interface;

namespace Com.TestData.ConwayOsler.Interface.Page.Home
{
  public class Home : CoreInterface
  {
    public void ClickSignIn(string elementId = "login")
    {
      Client.Actions.Click.ElementClass(elementId);
    }
  }
}
