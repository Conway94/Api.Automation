using Com.Core.ConwayOsler.Handlers.Client.Helper;
using System;

namespace Com.Core.ConwayOsler.Handlers.Client.Actions
{
  public class LaunchAction : SeleniumHelper
  {
    /// <summary>
    /// Setup of the selenium driver and launcher of the specified website.
    /// </summary>
    /// <param name="launchUrl">The website url to be launched.</param>
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
