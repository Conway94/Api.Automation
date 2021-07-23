using Com.Core.ConwayOsler.Handlers.Client.Helper;
using OpenQA.Selenium;
using System;

namespace Com.Core.ConwayOsler.Handlers.Client.Actions
{
  public class SelectAction : SeleniumHelper
  {
    /// <summary>
    /// Attemps to opens the drop down element and select the specified value within.
    /// </summary>
    /// <param name="elementId">Represents the id element derived from the p.o.m.</param>
    /// <param name="selectValue">Represents the value to be selected from the drop down element.</param>
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
