using System;
using Com.TestData.ConwayOsler.Helper;
using OpenQA.Selenium;

namespace Com.TestData.ConwayOsler.Actions
{
  public class SelectAction : SeleniumHelper
  {
    public void DropDownSelect(string elementId, string selectValue)
    {
      IWebElement selector = Driver.FindElement(By.Id(elementId));
      selector.SendKeys(selectValue);
      selector.Submit();
      Console.WriteLine($"Successfully Selected {selectValue} from {elementId}");
    }
  }
}
