using Com.Core.ConwayOsler.Handlers.Client.Helper;
using OpenQA.Selenium;
using System;

namespace Com.Core.ConwayOsler.Handlers.Client.Actions
{
  public class ClickAction : SeleniumHelper
  {
    /// <summary>
    /// Attempts to simulate a click event on a specified class element.
    /// </summary>
    /// <param name="elementClass">Represents the class element derived from the p.o.m.</param>
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

    /// <summary>
    /// Attempts to simulate a click event on a specified class element by it's text.
    /// </summary>
    /// <param name="elementClass">Represents the class element derived from the p.o.m.</param>
    /// <param name="title">Represents the class title value derived from the p.o.m.</param>
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

    /// <summary>
    /// Attempts to simulate a click event on a specified id element.
    /// </summary>
    /// <param name="elementId">Represents the id element derived from the p.o.m.</param>
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

    /// <summary>
    /// Attempts to simulate a click event on a specified xpath element.
    /// </summary>
    /// <param name="xpath">Represents the xpath element derived from the p.o.m.</param>
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

    /// <summary>
    /// Attempts to simulate a click event on a specified selector element.
    /// </summary>
    /// <param name="cssSelector">Represents the selector element derived from the p.o.m.</param>
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
