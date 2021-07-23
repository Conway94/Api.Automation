using Com.Core.ConwayOsler.Handlers.Client.Helper;
using System;

namespace Com.Core.ConwayOsler.Handlers.Client.Actions
{
  public class LaunchAction : SeleniumHelper
  {
    public void Chrome(string launchUrl)
    {
      try
      {
        ChromeWebDriver();
        Driver.Manage().Window.Maximize();
        Driver.Navigate().GoToUrl(launchUrl);
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        Console.WriteLine($"Successfully Launched Website {launchUrl}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Attempt to Launch Website {launchUrl} was unsuccessful");
        throw;
      }
    }
  }
}
