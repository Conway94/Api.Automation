using System;
using System.Threading;
using Com.Core.ConwayOsler.Handlers.Client.Helper;
using OpenQA.Selenium;

namespace Com.Core.ConwayOsler.Handlers.Client.Actions
{
  public class WaitAction : SeleniumHelper
  {
    public void ForElementId(string elementId)
    {
      Driver.FindElement(By.Id(elementId));
    }

    public void ForClassName(string className)
    {
      Driver.FindElement(By.ClassName(className));
    }

    public void ForCssSelector(string cssSelector)
    {
      Driver.FindElement(By.CssSelector(cssSelector));
    }
  }
}
