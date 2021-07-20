using Com.TestData.ConwayOsler.Helper;
using OpenQA.Selenium;
using System;

namespace Com.TestData.ConwayOsler.Actions
{
  public class ClickAction : SeleniumHelper
  {
    public void ClickElementClass(string elementClass)
    {
      try
      {
        IWebElement button = Driver.FindElement(By.ClassName(elementClass));
        button.Click();
        Console.WriteLine($"Successfully Clicked {elementClass}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Attempt to Click {elementClass} was unsuccessful");
        Console.WriteLine(e);
        throw;
      }
      
    }

    public void ClickElementId(string elementId)
    {
      try
      {
        IWebElement button = Driver.FindElement(By.Id(elementId));
        button.Click();
        Console.WriteLine($"Successfully Clicked {elementId}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Attempt to Click {elementId} was unsuccessful");
        Console.WriteLine(e);
        throw;
      }
    }
  }
}
