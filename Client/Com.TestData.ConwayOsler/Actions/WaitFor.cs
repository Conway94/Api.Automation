using Com.TestData.ConwayOsler.Helper;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace Com.TestData.ConwayOsler.Actions
{
  public class WaitForAction : SeleniumHelper
  {
    public void ElementId(string elementId)
    {
      Driver.FindElement(By.Id(elementId));
    }
  }
}
