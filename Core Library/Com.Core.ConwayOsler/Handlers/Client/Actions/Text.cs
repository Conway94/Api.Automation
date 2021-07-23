using Com.Core.ConwayOsler.Handlers.Client.Helper;
using OpenQA.Selenium;
using System;
using NUnit.Framework;

namespace Com.Core.ConwayOsler.Handlers.Client.Actions
{
  public class TextAction : SeleniumHelper
  {
    public void InsertTextIntoIdField(string elementId, string inputText)
    {
      try
      {
        IWebElement field = Driver.FindElement(By.Id(elementId));
        field.SendKeys(inputText);
        field.SendKeys(Keys.Tab);
        Console.WriteLine($"Successfully Inserted Text '{inputText}' into {elementId} field");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Attempt to Insert Text '{inputText}' into {elementId} field was unsuccessful");
        throw;
      }
    }

    public void InsertTextIntoCssField(string cssSelector, string inputText)
    {
      try
      {
        IWebElement field = Driver.FindElement(By.CssSelector(cssSelector));
        field.Click();
        field.SendKeys(inputText);
        field.SendKeys(Keys.Tab);
        Console.WriteLine($"Successfully Inserted Text '{inputText}' into {cssSelector} field");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Attempt to Insert Text '{inputText}' into {cssSelector} field was unsuccessful");
        throw;
      }
    }

    public void ValidateTextId(string elementId, string text)
    {
      var pageText = "";
      try
      {
        IWebElement field = Driver.FindElement(By.Id(elementId));
        pageText = field.Text.Trim();
        Assert.True(pageText == text);
        Console.WriteLine($"Successfully Validated Expected Text : '{text}' Is Equal to Actual Text : {pageText}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Validation Unsuccessful Expected Text : '{text}' Is Not Equal to Actual Text : {pageText}");
        throw;
      }
    }

    public void ValidateTextClass(string classElement, string text)
    {
      var pageText = "";
      try
      {
        IWebElement field = Driver.FindElement(By.ClassName(classElement));
        pageText = field.Text.Trim();
        Assert.True(pageText == text);
        Console.WriteLine($"Successfully Validated Expected Text : '{text}' Is Equal to Actual Text : {pageText}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Validation Unsuccessful Expected Text : '{text}' Is Not Equal to Actual Text : {pageText}");
        throw;
      }
    }

    public void ValidateTextCssSelector(string cssSelector, string text)
    {
      var pageText = "";
      try
      {
        IWebElement field = Driver.FindElement(By.CssSelector(cssSelector));
        pageText = field.Text.Trim();
        Assert.True(pageText == text);
        Console.WriteLine($"Successfully Validated Expected Text : '{text}' Is Equal to Actual Text : {pageText}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Validation Unsuccessful Expected Text : '{text}' Is Not Equal to Actual Text : {pageText}");
        throw;
      }
    }
  }
}
