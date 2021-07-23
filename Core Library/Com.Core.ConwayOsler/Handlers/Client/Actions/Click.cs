using Com.Core.ConwayOsler.Handlers.Client.Helper;
using OpenQA.Selenium;
using System;

namespace Com.Core.ConwayOsler.Handlers.Client.Actions
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

    public void ClickElementClass(string elementClass, string title)
    {
      try
      {
        IWebElement button = Driver.FindElement(By.ClassName(elementClass));
        button.FindElement(By.TagName(title)).Click();
        Console.WriteLine($"Successfully Clicked {title}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Attempt to Click {title} was unsuccessful");
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

    public void ClickElementXpath(string xpath)
    {
      try
      {
        IWebElement button = Driver.FindElement(By.XPath(xpath));
        button.Click();
        Console.WriteLine($"Successfully Clicked {xpath}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Attempt to Click {xpath} was unsuccessful");
        Console.WriteLine(e);
        throw;
      }
    }

    public void ClickCssSelector(string cssSelector)
    {
      try
      {
        IWebElement button = Driver.FindElement(By.CssSelector(cssSelector));
        button.Click();
        Console.WriteLine($"Successfully Clicked {cssSelector}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Attempt to Click {cssSelector} was unsuccessful");
        Console.WriteLine(e);
        throw;
      }
    }
  }
}
