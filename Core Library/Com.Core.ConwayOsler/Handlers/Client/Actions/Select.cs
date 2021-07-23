using System;
using Com.Core.ConwayOsler.Handlers.Client.Helper;
using OpenQA.Selenium;

namespace Com.Core.ConwayOsler.Handlers.Client.Actions
{
  public class SelectAction : SeleniumHelper
  {
    public void DropDownSelect(string elementId, string selectValue)
    {
      try
      {
        IWebElement selector = Driver.FindElement(By.Id(elementId));
        selector.SendKeys(selectValue);
        selector.SendKeys(Keys.Enter);
        Console.WriteLine($"Successfully Selected {selectValue} from {elementId}");
      }
      catch (Exception)
      {
        Console.WriteLine($"Attempt to Select {selectValue} from {elementId} was unsuccessful");
        throw;
      }
    }
  }
}
