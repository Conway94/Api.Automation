using OpenQA.Selenium.Chrome;
using System;
using Com.TestData.ConwayOsler.Helper;
using OpenQA.Selenium;

namespace Com.TestData.ConwayOsler.Actions
{
  public class LaunchAction : SeleniumHelper
  {
    public void Chrome(string websiteLink)
    {
      ChromeWebDriver();
      Driver.Manage().Window.Maximize();
      Driver.Navigate().GoToUrl(websiteLink);
      Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
    }
  }
}
